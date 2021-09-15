using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Data
{
  public class RecruitmentRepository : RepositoryBase
  {
    public RecruitmentRepository(DataContext context) : base(context)
    {
    }

    public async Task<Recruitment> GetRecruitmentById(int id)
    {
        return await _context.Recruitment.FindAsync(id);
    }

    public async Task<PaginationList<Recruitment>> GetRecruitments(PaginationParams paginationParams)
    {        
        var query = _context.Recruitment.AsNoTracking().AsQueryable();

        query = paginationParams.SortBy switch {
            "Name" => query.OrderBy(e => e.Name),
            "IsActive" => query.OrderBy(e => e.IsActive),
            "LastDay" => query.OrderBy(e => e.LastDay),
            "CreatedAt" => query.OrderBy(e => e.CreatedAt),
            _ => query.OrderBy(e => e.Id),
        };

        return await PaginationList<Recruitment>.CreatePagination(query, paginationParams);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) >= 1;
    }

    public async Task<bool> CreateRecruitment(Recruitment recruitment)
    {
        _context.Recruitment.Add(recruitment);

        return await SaveChangesAsync();
    }

    public async Task<bool> UpdateRecruitment(Recruitment currentRecruit, Recruitment updatedRecruit)
    {
        if (updatedRecruit.PhotoUrl != null)
        {
            currentRecruit.PhotoUrl = updatedRecruit.PhotoUrl;
            currentRecruit.PublicId = updatedRecruit.PublicId;
        }

        currentRecruit.Description = updatedRecruit.Description;
        currentRecruit.Requirements = updatedRecruit.Requirements;
        currentRecruit.Benefits = updatedRecruit.Benefits;
        currentRecruit.Experience = updatedRecruit.Experience;
        currentRecruit.Location = updatedRecruit.Location;
        currentRecruit.ContactWithUs = updatedRecruit.ContactWithUs;
        currentRecruit.IsActive = updatedRecruit.IsActive;
        currentRecruit.LastDay = updatedRecruit.LastDay;

        _context.Recruitment.Update(currentRecruit);

        return await SaveChangesAsync();
    }
    
    public async Task<bool> DeleteRecruitment(Recruitment recruitment)
    {
        _context.Recruitment.Remove(recruitment);

        return await SaveChangesAsync();
    }

    public async Task<bool> Apply(AppliedPerson appliedPerson, int recruitmentId)
    {
        var recruitment = await _context.Recruitment
            .Include(re => re.AppliedPeople)
            .SingleOrDefaultAsync(re => re.Id == recruitmentId);

        recruitment.AppliedPeople.Add(appliedPerson);

        return await SaveChangesAsync();
    }
  }
}