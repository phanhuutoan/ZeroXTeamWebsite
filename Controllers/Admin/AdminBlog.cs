using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/blog")]
    public class AdminBlog : AdminControllerBase
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Blogs";
            return View();
        }
    }
}