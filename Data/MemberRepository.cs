using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Data
{
  public class MemberRepository : RepositoryBase
  {
    public MemberRepository(DataContext context) : base(context)
    {
    }

    public async Task<bool> SaveChangeAsync()
    {
        var result = await _context.SaveChangesAsync();

        return result >= 1;
    }

    public async Task<Member> GetMemberById(int id)
    {
        return await _context.Member
            .Include(mem => mem.ProjectJoined)
            .SingleOrDefaultAsync(mem => mem.Id == id);
    }

    public async Task<PaginationList<Member>> GetMembers(PaginationParams paginationParams)
    {
        var query = _context.Member.AsNoTracking().AsQueryable();

        query = paginationParams.SortBy switch {
            "Name" => query.OrderBy(m => m.Name),
            "TeamTitles" => query.OrderBy(m => m.TeamTitles),
            "DateOfBirth" => query.OrderBy(m => m.DateOfBirth),
            "JoinedAt" => query.OrderBy(m => m.JoinedAt),
            _ => query.OrderBy(m => m.Id)
        };

        return await PaginationList<Member>.CreatePagination(query, paginationParams);
    }

    public async Task<ICollection<Member>> GetMembers(List<int> filteredIds)
    {
        return await _context.Member.Where(mem => !filteredIds.Contains(mem.Id)).ToListAsync();
    }

    public async Task<bool> AddMember(Member member)
    {
        _context.Member.Add(member);

        return await SaveChangeAsync();
    }

    public async Task<bool> UpdateMember(Member member, Member newMember)
    {
        if (!string.IsNullOrEmpty(newMember.PhotoUrl))
        {
            member.PhotoUrl = newMember.PhotoUrl;
            member.PublicId = newMember.PublicId;
        }

        member.Name = newMember.Name;
        member.Bio = newMember.Bio;
        member.TeamTitles = newMember.TeamTitles;
        member.JoinedAt = newMember.JoinedAt;

        _context.Member.Update(member);

        return await SaveChangeAsync();
    }

    public async Task<bool> DeleteMember(Member member)
    {
        _context.Member.Remove(member);

        return await SaveChangeAsync();
    }

    public async Task<List<Member>> GetMemberByListOfIds(List<int> ids)
    {
        return await _context.Member
            .Where(member => ids.Contains(member.Id))
            .ToListAsync();
    }
  }
}