using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZeroXTeam.Models;
using ZeroXTeam.Data;

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
