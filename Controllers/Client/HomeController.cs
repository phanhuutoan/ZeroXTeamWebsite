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
using System.Linq;
using System.Collections.Generic;

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
    private readonly BlogRepository _blogRepo;
    private readonly IMapper _mapper;

    public HomeController(
            InformationRepository informationRepository,
            MemberRepository memberRepository,
            ProjectRepository projectRepository,
            ContactRepository contactRepository,
            RecruitmentRepository recruitmentRepository,
            PhotoUploadService photoUploadService,
            BlogRepository blogRepository,
            IMapper mapper
        )
        {
            _informationRepo = informationRepository;
            _memberRepo = memberRepository;
            _projectRepo = projectRepository;
            _contactRepo = contactRepository;
            _recruitRepo = recruitmentRepository;
            _photoService = photoUploadService;
            _blogRepo = blogRepository;
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

        [HttpGet("blogs")]
        public async Task<IActionResult> GetBlogs(PaginationParams paginationParams)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Blog;
            ViewData["Title"] = "Bài viết mới nhất";

            var newestBlogs = await _blogRepo.GetNewestBlogs();
            var excludedIds = newestBlogs.Select(item => item.Id).ToList();

            var otherBlogs = await _blogRepo.GetBlogWithoutSpecificIds(paginationParams, excludedIds);

            ViewData["NewestBlogs"] = newestBlogs;
            ViewData["RemainingBlogs"] = otherBlogs;

            return View("Blogs");
        }

        [HttpGet("blogs/{id}")]
        public async Task<IActionResult> GetBlogDetail(int id)
        {
            ViewData["ActiveMenu"] = ActiveMenu.Blog;

            var seeMuchParams = new PaginationParams()
            {
                ItemPerPage = 4,
                PageNumber = 1,
                SortBy = "Views"
            };

            var latestBlogParams = new PaginationParams()
            {
                ItemPerPage = 6,
                PageNumber = 1,
                SortBy = "CreatedAt"
            };

            var blog = await _blogRepo.GetBlogById(id);

            await _blogRepo.UpdateBlogViews(id);

            var remainingBlogs = await _blogRepo.GetBlogWithoutSpecificIds(seeMuchParams, new List<int>() {id});
            var latestBlog = await _blogRepo.GetBlogWithoutSpecificIds(latestBlogParams, new List<int>() {id});

            ViewData["Blog"] = blog;
            ViewData["SeeMuchBlogs"] = remainingBlogs;
            ViewData["LatestBlogs"] = latestBlog;

            ViewData["Title"] = "Bài viết - " + blog.Name;            


            return View("BlogDetail");
        }

        [HttpPost("blogs/{id}/add-comment")]
        public async Task<IActionResult> AddComment(CommentViewModel commentViewModel, int id) 
        {   
            var comment = _mapper.Map<UserComment>(commentViewModel);

            await _blogRepo.AddComment(comment, id);

            return RedirectToAction("GetBlogDetail", new { id = id });
        }

        [HttpGet("members/{id}")]
        public async Task<IActionResult> MemberDetail(int id) 
        {   
            var member = await _memberRepo.GetMemberById(id);

            ViewData["Title"] = "Hồ sơ nhân sự zerox - " + member.Name ;

            ViewData["Member"] = member;

            return View("MemberDetail"); 
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

        [HttpGet("not-found")]
        public IActionResult NotFoundError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
