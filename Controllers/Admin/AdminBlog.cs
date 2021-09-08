using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/blog")]
    [Authorize]
    public class AdminBlog : AdminControllerBase
    {
    public AdminBlog(IMapper mapper) : base(mapper)
    {
    }

    public IActionResult Index()
        {
            ViewData["Title"] = "Blogs";
            ViewData["ActiveMenu"]="blog";

            return View();
        }
    }
}