using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZeroXTeam.Models;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Controllers.Client
{
    public class HomeController : Controller
    {

    private readonly InformationRepository _informationRepo;
    private readonly MemberRepository _memberRepo;
    private ProjectRepository _projectRepo;

    public HomeController(
            InformationRepository informationRepository,
            MemberRepository memberRepository,
            ProjectRepository projectRepository
        )
        {
            _informationRepo = informationRepository;
            _memberRepo = memberRepository;
            _projectRepo = projectRepository;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Information"] = await _informationRepo.GetInformation();
            ViewData["NumberOfMembers"] = await _memberRepo.GetTotal();
            ViewData["NumberOfProjects"] = await _projectRepo.GetTotal();
            ViewData["ShowedProjects"] = await _projectRepo.GetShowedItems();

            return View();
        }

        [HttpGet("projects")]
        public async Task<IActionResult> Projects(PaginationParams paginationParams)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Project;
            ViewData["Title"] = "Our Projects";
            ViewData["Projects"] = await _projectRepo.GetAllProjects(paginationParams);

            return View("Projects");
        }

        [HttpGet("projects/{id}")]
        public async Task<IActionResult> ProjectDetail(int id)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Project;
            var project = await _projectRepo.GetProjectViewModelById(id);
            ViewData["Project"] = project;
            ViewData["Title"] = "Project - " + project.Name;

            return View("ProjectDetail");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
