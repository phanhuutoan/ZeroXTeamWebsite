using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Entities;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using ZeroXTeam.Models.RenderViewModel;
using ZeroXTeam.Helpers;
using ZeroXTeam.DTOs;
using System;

namespace ZeroXTeam.Data
{
  public class ProjectRepository : RepositoryBase
  {
    private MemberRepository _memberRepo;
    private IMapper _mapper;

    public ProjectRepository(
      DataContext context,
      MemberRepository memberRepository,
      IMapper mapper
    ) : base(context)
    {
      _memberRepo = memberRepository;
      _mapper = mapper;
    }

    public async Task CreateProject(Project project)
    {
        _context.Project.Add(project);

        await _context.SaveChangesAsync();
    }

    public async Task<PaginationList<Project>> GetAllProjects(PaginationParams paginationParams)
    {
      var query =  _context.Project.AsQueryable();

      query = paginationParams.SortBy switch {
        "Name" => query.OrderBy(p => p.Name),
        "StartDate" => query.OrderBy(p => p.StartDate),
        _ => query.OrderBy(p => p.Id),
      };

      var paginationList = await PaginationList<Project>.CreatePagination(query.AsNoTracking(), paginationParams);

      return paginationList;
    }

    public async Task<RenderProjectViewModel> GetProjectViewModelById(int id)
    {
      return await _context.Project
        .Include(p => p.MemberJoined)
        .ProjectTo<RenderProjectViewModel>(_mapper.ConfigurationProvider)
        .AsNoTracking()
        .SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Project> GetProjectById(int id)
    {
      return await _context.Project
        .Include(p => p.MemberJoined)
        .SingleOrDefaultAsync(p => p.Id == id);
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

    public async Task<bool> AddOrRemoveMembers(List<int> ids, int projectId)
    {
      var project = await _context.Project
        .Include(project => project.MemberJoined)
        .SingleOrDefaultAsync(p => p.Id == projectId);
      
      project.MemberJoined.Clear();

      if (ids.Count == 0)
      {
        return await UpdateProject(project);
      }

      var members = await _memberRepo.GetMemberByListOfIds(ids);

      members.ForEach(member => {
        project.MemberJoined.Add(member);
      });

      return await UpdateProject(project);
    }
  }
}