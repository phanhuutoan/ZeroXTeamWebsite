using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Entities;

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

    public async Task<ICollection<Member>> GetMembers()
    {
        return await _context.Member.ToListAsync();
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