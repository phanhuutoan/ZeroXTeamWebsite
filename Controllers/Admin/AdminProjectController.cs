using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers
{
    public class AdminProjectController : AdminControllerBase
    {
    public AdminProjectController(IMapper mapper) : base(mapper)
    {
    }

    [Route("/admin/projects")]
        
        public IActionResult Index()
        {
            ViewData["ActiveMenu"]="project";
            ViewData["Title"] = "Projects";
            return View();
        }
    }
}