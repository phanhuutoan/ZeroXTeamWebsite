using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/members")]

    public class AdminMemberController : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Members";
            return View();
        }
    }
}