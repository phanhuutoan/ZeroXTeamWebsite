using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;
using ZeroXTeam.Models;
using ZeroXTeam.Services;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/blogs")]
    [Authorize]
    public class AdminBlogController : AdminControllerBase
    {
    private readonly BlogRepository _blogRepo;
    private readonly PhotoUploadService _photoService;
    const int HEIGHT = 700;
    const int WIDTH = 1000;
    public AdminBlogController(
            IMapper mapper,
            BlogRepository blogRepository,
            PhotoUploadService photoUploadService
        ) : base(mapper)
        {
            _blogRepo = blogRepository;
            _photoService = photoUploadService;
        }

        public async Task<IActionResult> Index(PaginationParams paginationParams)
        {
            SetTitleAndActiveMenu("Blogs", ActiveMenu.Blog);

            ViewData["Blogs"] = await _blogRepo.GetBlogs(paginationParams);

            return View();
        }

        [HttpGet("create")]
        public IActionResult GetCreate()
        {
            SetTitleAndActiveMenu("Blogs", ActiveMenu.Blog);

            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> PostCreate(BlogViewModel blogViewModel)
        {
            var blog = _mapper.Map<Blog>(blogViewModel); 

            if (blogViewModel.Photo != null)
            {
                var uploadResult = await _photoService.UploadImage(blogViewModel.Photo, HEIGHT, WIDTH);

                blog.PhotoUrl = uploadResult.ImageUrl;
                blog.PublicId = uploadResult.PublicId;
            }

            await _blogRepo.CreateBlog(blog);

            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEdit(int id)
        {
            SetTitleAndActiveMenu("Blogs", ActiveMenu.Blog);
            
            var blog = await _blogRepo.GetBlogById(id);

            ViewData["Blog"] = blog;
            ViewData["EditMode"] = true;

            return View("GetCreate");
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> GetEdit(BlogViewModel blogViewModel, int id)
        {
            SetTitleAndActiveMenu("Blogs", ActiveMenu.Blog);
            
            var blog = await _blogRepo.GetBlogById(id);

            var newBlog = _mapper.Map<Blog>(blogViewModel);

            if (blogViewModel.Photo != null)
            {
                await _photoService.DeleteImage(blog.PublicId);
                var uploadResult = await _photoService.UploadImage(blogViewModel.Photo, HEIGHT, WIDTH);

                blog.PhotoUrl = uploadResult.ImageUrl;
                blog.PublicId = uploadResult.PublicId;
            }

            await _blogRepo.UpdateBlog(blog, newBlog);

            return RedirectToAction("Index");
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _blogRepo.GetBlogById(id);

            if (string.IsNullOrEmpty(blog.PhotoUrl))
            {
                await _photoService.DeleteImage(blog.PublicId);
            }

            await _blogRepo.DeleteBlog(blog);

            return RedirectToAction("Index");
        }     

        [HttpPost("{blogId}/delete-comment/{id}")]
        public async Task<IActionResult> DeleteComment(int id, int blogId)
        {
            await _blogRepo.RemoveComment(id, blogId);

            return RedirectToAction("GetEdit", new { id = blogId });
        }     

        [HttpGet("search")]
        public async Task<IActionResult> GetSearch(string searchString)
        {
            SetTitleAndActiveMenu("Search blog", ActiveMenu.Blog);
            
            ViewData["Blogs"] = await _blogRepo.Search(searchString);

            return View("Index");
        }
    }

}