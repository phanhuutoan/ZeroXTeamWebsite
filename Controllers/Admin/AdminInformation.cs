using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Authorize]
    [Route("/admin/information")]
    public class AdminInformation : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Landing page information";
            ViewData["ActiveMenu"] = "information";

            return View();
        }
    }
}