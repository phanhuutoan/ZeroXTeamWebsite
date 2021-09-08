using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Entities;

namespace ZeroXTeam.Data
{
  public class ProjectRepository : RepositoryBase
  {

    public ProjectRepository(DataContext context) : base(context)
    {
    }

    public async Task CreateProject(Project project)
    {
        _context.Project.Add(project);

        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> GetAllProjects()
    {
      return await _context.Project.ToListAsync();
    }

    public async Task<Project> GetProjectById(int id)
    {
      return await _context.Project.FindAsync(id);
    }

    public async Task<bool> UpdateProject(Project newProject)
    {
      var project = await _context.Project.FindAsync(newProject.Id);

      project.Name = newProject.Name;
      project.Description = newProject.Description;
      
      if (!string.IsNullOrEmpty(newProject.PhotoUrl))
      {
        project.PhotoUrl = newProject.PhotoUrl;
        project.PublicId = newProject.PublicId;
      }
      
      project.Page = newProject.Page;
      project.Repository = newProject.Repository;
      project.EndDate = newProject.EndDate;
      project.StartDate = newProject.StartDate;

      _context.Project.Update(project);

      var result = await _context.SaveChangesAsync();

      return result >= 1;
    } 

    public async Task<bool> DeleteProject(Project project)
    {
      _context.Project.Remove(project);

      var result = await _context.SaveChangesAsync();

      return result >= 1;
    }
  }
}