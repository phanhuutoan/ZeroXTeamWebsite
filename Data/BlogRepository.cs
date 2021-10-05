using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Data
{
  public class BlogRepository : RepositoryBase
  {
    public BlogRepository(DataContext context) : base(context)
    {
    }

    public async Task<Blog> GetBlogById(int id)
    {
        return await _context
            .Blog
            .Include(blog => blog.UserComments)
            .SingleOrDefaultAsync(blog => blog.Id == id);
    }

    public async Task<bool> UpdateBlogViews(int id)
    {
        var blog = await _context.Blog.FindAsync(id);

        blog.Views += 1;

        _context.Blog.Update(blog);

        return await SaveChangeAsync();
    }

    public async Task<PaginationList<Blog>> GetBlogs(PaginationParams paginationParams)
    {
        var query = _context.Blog.AsNoTracking().AsQueryable();

        query = paginationParams.SortBy switch {
            "Name" => query.OrderBy(e => e.Name),
            "CreatedAt" => query.OrderBy(e => e.CreatedAt),
            "UpdatedAt" => query.OrderBy(e => e.UpdatedAt),
            "Author" => query.OrderBy(e => e.Author),
            "Views" => query.OrderBy(e => e.Views),
            _ => query.OrderBy(e => e.Id)
        };

        return await PaginationList<Blog>.CreatePagination(query, paginationParams);
    }

    public async Task<PaginationList<Blog>> GetBlogWithoutSpecificIds(PaginationParams paginationParams, List<int> ids)
    {
        var query = _context.Blog.AsNoTracking().AsQueryable();

        query = paginationParams.SortBy switch {
            "Name" => query.OrderBy(e => e.Name),
            "CreatedAt" => query.OrderBy(e => e.CreatedAt),
            "UpdatedAt" => query.OrderBy(e => e.UpdatedAt),
            "Author" => query.OrderBy(e => e.Author),
            "Views" => query.OrderByDescending(e => e.Views),
            _ => query.OrderBy(e => e.Id)
        };

        query = query.Where(blog => !ids.Contains(blog.Id));

        return await PaginationList<Blog>.CreatePagination(query, paginationParams);
    }

    public async Task<List<Blog>> GetNewestBlogs()
    {
        var query = _context.Blog.AsNoTracking().AsQueryable();

        query = query.OrderByDescending(blog => blog.CreatedAt).Take(5);

        return await query.ToListAsync();
    }

    public async Task<bool> SaveChangeAsync()
    {
        var result = await _context.SaveChangesAsync();

        return result >= 1;
    }

    public async Task<bool> CreateBlog(Blog blog)
    {
        _context.Blog.Add(blog);

        return await SaveChangeAsync();
    }

    public async Task<bool> UpdateBlog(Blog currentBlog, Blog newBlog)
    {
        if (!string.IsNullOrEmpty(newBlog.PhotoUrl))
        {
            currentBlog.PublicId = newBlog.PublicId;
            currentBlog.PhotoUrl = newBlog.PhotoUrl;
        }

        currentBlog.Author = newBlog.Author;
        currentBlog.Name = newBlog.Name;
        currentBlog.Content = newBlog.Content;
        currentBlog.Brief = newBlog.Brief;
        currentBlog.UpdatedAt = DateTime.Today;

        _context.Blog.Update(currentBlog);

        return await SaveChangeAsync();
    }

    public async Task<bool> DeleteBlog(Blog blog)
    {
        _context.Blog.Remove(blog);

        return await SaveChangeAsync();
    }

    public async Task<PaginationList<Blog>> Search(string searchStr)
    {
        var query =  _context.Blog
            .Where(p => 
                p.Name.ToLower().Contains(searchStr.ToLower()) || 
                p.Brief.ToLower().Contains(searchStr.ToLower()) ||
                p.Content.ToLower().Contains(searchStr.ToLower())
            );

        return await PaginationList<Blog>.CreatePagination(query, new PaginationParams() 
        {
            PageNumber = 1,
            ItemPerPage = 30    
        }, true);
    }

    public async Task<bool> AddComment(UserComment userComment, int blogId)
    {
        var blog = await GetBlogById(blogId);

        blog.UserComments.Add(userComment);

        _context.Blog.Update(blog);

        return await SaveChangeAsync();
    }

    public async Task<bool> RemoveComment(int commentId, int blogId)
    {
        var blog = await GetBlogById(blogId);

        var comment = blog.UserComments.SingleOrDefault(cmt => cmt.Id == commentId);

        blog.UserComments.Remove(comment);

        _context.Blog.Update(blog);

        return await SaveChangeAsync();
    }
  }
}