using AutoMapper;
using ZeroXTeam.Entities;
using ZeroXTeam.Models;
using ZeroXTeam.Models.RenderViewModel;

namespace ZeroXTeam.Helpers
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
        CreateMap<HomePageInformation, InformationViewModel>();
        CreateMap<ProjectViewModel, Project>();
        CreateMap<MemberViewModel, Member>();
        CreateMap<Project, RenderProjectViewModel>();
        CreateMap<Member, RenderMemberViewModel>();
        CreateMap<BlogViewModel, Blog>();
        CreateMap<RecruitmentViewModel, Recruitment>();
        CreateMap<ApplyViewModel, AppliedPerson>();
    }
  }
}