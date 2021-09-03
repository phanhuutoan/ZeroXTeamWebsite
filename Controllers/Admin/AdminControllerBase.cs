using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Controllers
{
    
    [ServiceFilter(typeof(AdminFilterAction))]
    public abstract class AdminControllerBase : Controller
    {
        public AdminControllerBase() 
        {
        }
    }
}