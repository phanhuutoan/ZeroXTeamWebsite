using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.Entities;
using ZeroXTeam.Models;
using ZeroXTeam.Services;

namespace ZeroXTeam.Controllers
{
    [Authorize]
    [Route("admin/projects")]
    public class AdminProjectController : AdminControllerBase
    {
    private readonly ProjectRepository _projectRepo;
    private readonly PhotoUploadService _photoService;
    const int IMAGE_HEIGHT = 600;
    const int IMAGE_WIDTH = 800;

    public AdminProjectController(
        IMapper mapper, 
        ProjectRepository projectRepository,
        PhotoUploadService photoUploadService
        ) : base(mapper)
        {
            _projectRepo = projectRepository;
            _photoService = photoUploadService;
        }

        [HttpGet]        
        public async Task<IActionResult> Index()
        {
            ViewData["ActiveMenu"]="project";
            ViewData["Title"] = "Projects";

            var listProjects = await _projectRepo.GetAllProjects();

            ViewData["ListProjects"] = listProjects;

            return View();
        }

        [HttpGet("create")]
        public IActionResult GetCreate()
        {
            ViewData["ActiveMenu"]="project";
            ViewData["Title"] = "Projects";

            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> PostCreate(ProjectViewModel projectViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid Data");

            var project = _mapper.Map<Project>(projectViewModel);                 

            if (projectViewModel.Photo.Length > 0)
            {
                var uploadResult = await _photoService.UploadImage(projectViewModel.Photo, IMAGE_HEIGHT, IMAGE_WIDTH);
                project.PhotoUrl = uploadResult.ImageUrl;
                project.PublicId = uploadResult.PublicId;
            }

            await _projectRepo.CreateProject(project);

            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEdit(int id)
        {
            ViewData["ActiveMenu"]="project";
            ViewData["Title"] = "Projects";

            var project = await _projectRepo.GetProjectById(id);

            if (project == null) return NotFound();

            ViewData["Project"] = project;
            ViewData["EditMode"] = true;

            return View("GetCreate");
        }

        [HttpPost("edit")]
        public async Task<IActionResult> PostEdit(ProjectViewModel projectViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid Data");

            var project = _mapper.Map<Project>(projectViewModel);

            if (projectViewModel?.Photo?.Length > 0)
            {
                await _photoService.DeleteImage(project.PublicId);

                var uploadResult = await _photoService.UploadImage(projectViewModel.Photo, IMAGE_HEIGHT, IMAGE_WIDTH);
                project.PhotoUrl = uploadResult.ImageUrl;
                project.PublicId = uploadResult.PublicId;
            }

            var updateResult = await _projectRepo.UpdateProject(project);

            if (!updateResult) return BadRequest("Update failed");

            return RedirectToAction("Index");
        } 

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> PostDelete(int id)
        {
            var project = await _projectRepo.GetProjectById(id);

            await _photoService.DeleteImage(project.PublicId);

            if (await _projectRepo.DeleteProject(project))
            {
                return View("Index");
            }

            return BadRequest("Delete failed");
        }   
    }
}