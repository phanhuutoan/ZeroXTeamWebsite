using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/members")]
    [Authorize]
    public class AdminMemberController : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Members";
            ViewData["ActiveMenu"]="member";

            return View();
        }
    }
}