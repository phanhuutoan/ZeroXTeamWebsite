using System.Threading.Tasks;
using ZeroXTeam.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ZeroXTeam.Data
{
  public class InformationRepository : RepositoryBase
  {
    public InformationRepository(DataContext context) : base(context)
    {
    }

    public async Task<HomePageInformation> GetInformation()
    {
        return await _context.HomePageInformation.OrderBy(u => u.Id).FirstOrDefaultAsync();
    }

    public async Task<bool> UpdateInformation(HomePageInformation information) 
    {
      if (!(await _context.HomePageInformation.AnyAsync()))
      {
        _context.HomePageInformation.Add(information);
      }
      else 
      {
        var existedData = await _context.HomePageInformation.FirstOrDefaultAsync();

        existedData.Title = information.Title;
        existedData.SubTitle = information.SubTitle;

        if (!string.IsNullOrEmpty(information.AboutUrl))
        {
          existedData.AboutPublicId = information.AboutPublicId;
          existedData.AboutUrl = information.AboutUrl;
        }

        if(!string.IsNullOrEmpty(information.HeroUrl))
        {
          existedData.HeroPublicId = information.HeroPublicId;
          existedData.HeroUrl = information.HeroUrl;
        }

        _context.HomePageInformation.Update(existedData);
      }

      var result = await _context.SaveChangesAsync();

      return result > 1;
    }
  }
}