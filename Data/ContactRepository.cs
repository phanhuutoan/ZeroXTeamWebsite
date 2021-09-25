using System.Threading.Tasks;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Data
{
  public class ContactRepository : RepositoryBase
  {
    public ContactRepository(DataContext context) : base(context)
    {
    }
    public async Task<PaginationList<Contact>> GetContactLetters(PaginationParams paginationParams, bool? isRead)
    {
        var query = _context
          .Contact
          .AsNoTracking().AsQueryable();

        if ((bool)isRead) {
          query = query.Where(item => item.HasRead);
        } else {
          query = query.Where(item => !item.HasRead);
        }

        query = _addSortingQuery(query, paginationParams.SortBy);

        return await PaginationList<Contact>.CreatePagination(query, paginationParams);
    }

    public async Task<PaginationList<Contact>> GetHasReadLetter(PaginationParams paginationParams)
    {
      var query = _context
          .Contact
          .Where(item => item.HasRead)
          .AsNoTracking().AsQueryable();

        query = _addSortingQuery(query, paginationParams.SortBy);

        return await PaginationList<Contact>.CreatePagination(query, paginationParams);
    }

    public async Task<Contact> GetContactLetter(int Id)
    {
      return await _context.Contact.FindAsync(Id);
    } 


    public async Task<bool> CreateContactLetter(Contact contact)
    {
        _context.Contact.Add(contact);

        return await SaveChangesAsync();
    }

    public async Task<bool> SaveChangesAsync()
    {
        var index = await _context.SaveChangesAsync();

        return index >= 1;
    }

    public async Task<bool> DeleteContactLetter(Contact contact)
    {
        _context.Contact.Remove(contact);

        return await SaveChangesAsync();
    }

    public async Task<bool> UpdateReadStatus(Contact contact)
    {
      contact.HasRead = true;
      
      _context.Contact.Update(contact);

      return await SaveChangesAsync();
    }

    private IQueryable<Contact> _addSortingQuery(IQueryable<Contact> query, string sortString)
    {
      return sortString switch {
        "CreatedAt" => query.OrderBy(c => c.CreatedAt),
        "Name" => query.OrderBy(c => c.Name),
        "Email" => query.OrderBy(c => c.Mail),
        _ => query.OrderBy(c => c.Id)          
      };
    }
  }
}