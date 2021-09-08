using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Controllers
{    
    [ServiceFilter(typeof(AdminFilterAction))]
    public abstract class AdminControllerBase : Controller
    {
        protected readonly IMapper _mapper;

        public AdminControllerBase(IMapper mapper) 
        {
            _mapper = mapper;
        }
    }
}