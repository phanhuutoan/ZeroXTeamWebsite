using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers
{
    public class AdminProjectController : AdminControllerBase
    {
        [Route("/admin/projects")]
        [Authorize]
        public IActionResult Index()
        {
            ViewData["ActiveMenu"]="project";
            ViewData["Title"] = "Projects";
            return View();
        }
    }
}