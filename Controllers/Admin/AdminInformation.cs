using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/information")]

    public class AdminInformation : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Landing page information";
            return View();
        }
    }
}