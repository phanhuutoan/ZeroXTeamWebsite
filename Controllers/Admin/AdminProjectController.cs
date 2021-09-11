using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;
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
    private readonly MemberRepository _memberRepo;
    const int IMAGE_HEIGHT = 600;
    const int IMAGE_WIDTH = 800;

    public AdminProjectController(
        IMapper mapper, 
        ProjectRepository projectRepository,
        PhotoUploadService photoUploadService,
        MemberRepository memberRepository
        ) : base(mapper)
        {
            _projectRepo = projectRepository;
            _photoService = photoUploadService;
            _memberRepo = memberRepository;
        }

        [HttpGet]        
        public async Task<IActionResult> Index()
        {
            SetTitleAndActiveMenu("Projects page", ActiveMenu.Project);

            var listProjects = await _projectRepo.GetAllProjects();

            ViewData["ListProjects"] = listProjects;

            return View();
        }

        [HttpGet("create")]
        public IActionResult GetCreate()
        {
            SetTitleAndActiveMenu("Projects page", ActiveMenu.Project);

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
            SetTitleAndActiveMenu("Projects page", ActiveMenu.Project);

            var project = await _projectRepo.GetProjectViewModelById(id);

            if (project == null) return NotFound();            

            var listMembers = await _memberRepo.GetMembers(
                project.MemberJoined.Select(mem => mem.Id).ToList()
            );

            ViewData["Members"] = listMembers;

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
                return Ok();
            }

            return BadRequest("Delete failed");
        }

        [HttpPost("add-members/{id}")]  
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostAddMembers([FromQuery] string memberIds, int id)
        {
            var stringArr = memberIds?.Split(",").ToList();
            
            var memberIdIntList = new List<int>();

            if (!string.IsNullOrEmpty(memberIds))
            {
                memberIdIntList = stringArr.Select(str => int.Parse(str)).ToList();
            }

            await _projectRepo.AddOrRemoveMembers(memberIdIntList, id);

            return RedirectToAction("GetEdit", new {id = id});
        }

    }
}