using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Models;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Helpers;
using ZeroXTeam.Entities;

namespace ZeroXTeam.Controllers.Client
{
  public class HomeController : Controller
    {

    private readonly InformationRepository _informationRepo;
    private readonly MemberRepository _memberRepo;
    private ProjectRepository _projectRepo;
    private readonly ContactRepository _contactRepo;

    public HomeController(
            InformationRepository informationRepository,
            MemberRepository memberRepository,
            ProjectRepository projectRepository,
            ContactRepository contactRepository
        )
        {
            _informationRepo = informationRepository;
            _memberRepo = memberRepository;
            _projectRepo = projectRepository;
            _contactRepo = contactRepository;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Information"] = await _informationRepo.GetInformation();
            ViewData["NumberOfMembers"] = await _memberRepo.GetTotal();
            ViewData["NumberOfProjects"] = await _projectRepo.GetTotal();
            ViewData["ShowedProjects"] = await _projectRepo.GetShowedItems();

            return View();
        }

        [HttpGet("about")]
        public async Task<IActionResult> About()
        {
            ViewData["ActiveMenu"] = ActiveMenu.About;
            ViewData["Title"] = "Về chúng tôi";
            ViewData["Information"] = await _informationRepo.GetInformation();
            ViewData["Members"] = await _memberRepo.GetShowedItems();

            return View("AboutUs");
        }

        [HttpGet("projects")]
        public async Task<IActionResult> Projects(PaginationParams paginationParams)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Project;
            ViewData["Title"] = "Dự án";
            ViewData["Projects"] = await _projectRepo.GetAllProjects(paginationParams);

            return View("Projects");
        }

        [HttpGet("projects/{id}")]
        public async Task<IActionResult> ProjectDetail(int id)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Project;
            var project = await _projectRepo.GetProjectViewModelById(id);
            ViewData["Project"] = project;
            ViewData["Title"] = "Dự án - " + project.Name;

            return View("ProjectDetail");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewData["ActiveMenu"] = ActiveMenu.Contact;
            ViewData["Title"] = "Liên hệ";

            return View("Contact");
        }

        [HttpPost("contact")]
        public async Task<IActionResult> PostContact(Contact contact)
        {
            if (!ModelState.IsValid) return BadRequest("Bad request");

            await _contactRepo.CreateContactLetter(contact);

            TempData["SuccessMessage"] = "Send letter successfully.";

            return RedirectToAction("contact");
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
