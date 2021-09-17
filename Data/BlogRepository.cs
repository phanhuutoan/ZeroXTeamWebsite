using System;
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
        return await _context.Blog.FindAsync(id);
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
  }
}