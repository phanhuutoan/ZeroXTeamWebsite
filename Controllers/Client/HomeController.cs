using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Models;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Helpers;
using ZeroXTeam.Entities;
using ZeroXTeam.Services;
using AutoMapper;

namespace ZeroXTeam.Controllers.Client
{
    public class HomeController : Controller
    {

    private readonly InformationRepository _informationRepo;
    private readonly MemberRepository _memberRepo;
    private ProjectRepository _projectRepo;
    private readonly ContactRepository _contactRepo;
    private readonly RecruitmentRepository _recruitRepo;
    private readonly PhotoUploadService _photoService;
    private readonly IMapper _mapper;

    public HomeController(
            InformationRepository informationRepository,
            MemberRepository memberRepository,
            ProjectRepository projectRepository,
            ContactRepository contactRepository,
            RecruitmentRepository recruitmentRepository,
            PhotoUploadService photoUploadService,
            IMapper mapper
        )
        {
            _informationRepo = informationRepository;
            _memberRepo = memberRepository;
            _projectRepo = projectRepository;
            _contactRepo = contactRepository;
            _recruitRepo = recruitmentRepository;
            _photoService = photoUploadService;
            _mapper = mapper;
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

        [HttpGet("recruitments")]
        public async Task<IActionResult> GetRecruitments(PaginationParams paginationParams)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Recruitment;
            ViewData["Title"] = "Tuyển dụng";

            ViewData["Recruitments"] = await _recruitRepo.GetRecruitments(paginationParams);

            return View("Recruitments");            
        }

        [HttpGet("recruitments/{id}")]
        public async Task<IActionResult> RecruitmentDetail(int id)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Recruitment;

            var recruitment = await _recruitRepo.GetRecruitmentById(id);

            ViewData["Recruitment"] = recruitment;
            ViewData["Title"] = recruitment.Name;
            
            return View("RecruitmentDetail");            
        }

        [HttpPost("recruitments/{id}/apply")]
        public async Task<IActionResult> Apply(ApplyViewModel applyViewModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid Data");

            var appliedPerson = _mapper.Map<AppliedPerson>(applyViewModel);

            if (applyViewModel.CvFile != null)
            {
                var uploadResult = await _photoService.UploadFile(applyViewModel.CvFile);
                appliedPerson.CvUrl = uploadResult.FileUrl;
                appliedPerson.PublicId = uploadResult.PublicId;
            }

            await _recruitRepo.ApplyToRecruitment(id, appliedPerson);

            TempData["Message"] = "Bạn đã thành công apply, chờ liên hệ của chúng tôi nhé :D";

            return RedirectToAction("RecruitmentDetail", new {id = id});

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
