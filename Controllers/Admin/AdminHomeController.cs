using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers
{
    [Route("admin")]
    public class AdminHomeController : AdminControllerBase
    {
        public AdminHomeController() : base()
        {
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home"; 
            return View();
        }
    }
}