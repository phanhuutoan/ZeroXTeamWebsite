using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/email")]
    public class AdminEmail : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Customer Email";
            return View();
        }
        
    }
}