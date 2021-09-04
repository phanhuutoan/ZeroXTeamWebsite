using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/email")]
    [Authorize]
    public class AdminEmail : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Customer Email";
            ViewData["ActiveMenu"] = "email";
            return View();
        }
        
    }
}