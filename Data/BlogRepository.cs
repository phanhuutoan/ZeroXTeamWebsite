using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Entities;

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

    public async Task<List<Blog>> GetBlogs()
    {
        return await _context.Blog.ToListAsync();
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

  }
}