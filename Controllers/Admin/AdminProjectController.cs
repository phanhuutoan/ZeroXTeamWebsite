using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers
{
    public class AdminProjectController : AdminControllerBase
    {
        [Route("/admin/projects")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Projects";
            return View();
        }
    }
}