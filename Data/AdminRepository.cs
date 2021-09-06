using System.Threading.Tasks;
using ZeroXTeam.Entities;
using Microsoft.EntityFrameworkCore;

namespace ZeroXTeam.Data
{
  public class AdminRepository : RepositoryBase
  {
    public AdminRepository(DataContext context) : base(context)
    {
    }

    public async Task<AdminAccount> GetAdminAccountByEmailAsync(string email)
    {
        return await _context.AdminAccount.SingleOrDefaultAsync(u => u.Email == email);            
    }

    public async Task<bool> AnyAdminAsync()
    {
        return await _context.AdminAccount.AnyAsync();
    }

    public void CreateAdmin(AdminAccount adminAccount)
    {
        _context.AdminAccount.Add(adminAccount);
    }

    public async Task<bool> SaveAllChangeAsync()
    {
        var result = await _context.SaveChangesAsync();

        return result > 0;
    }
  }
}