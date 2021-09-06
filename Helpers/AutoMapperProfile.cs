using AutoMapper;
using ZeroXTeam.Entities;
using ZeroXTeam.Models;

namespace ZeroXTeam.Helpers
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
        CreateMap<HomePageInformation, InformationViewModel>();
    }
  }
}