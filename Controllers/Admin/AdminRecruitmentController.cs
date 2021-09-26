using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Entities;
using ZeroXTeam.Helpers;
using ZeroXTeam.Models;
using ZeroXTeam.Services;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/recruitment")]
    public class AdminRecruitmentController : AdminControllerBase
    {
        private PhotoUploadService _photoService;
        private RecruitmentRepository _recruitRepo;

        public AdminRecruitmentController(
            IMapper mapper,
            PhotoUploadService photoUploadService,
            RecruitmentRepository recruitmentRepository
        ) : base(mapper)
        {
            _photoService = photoUploadService;
            _recruitRepo = recruitmentRepository;
        }
        public async Task<IActionResult> Index(PaginationParams paginationParams)
        {
            SetTitleAndActiveMenu("Recruit members", ActiveMenu.Recruitment);

            var recruitment = await _recruitRepo.GetRecruitments(paginationParams);

            ViewData["Recruitments"] = recruitment;
            
            return View();
        }

        [HttpGet("create")]
        public IActionResult GetCreate()
        {
            SetTitleAndActiveMenu("Recruit members", ActiveMenu.Recruitment);

            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> PostCreate(RecruitmentViewModel recruitmentViewModel)
        {
            if (ModelState.IsValid) return BadRequest("Invalid Data");

            var recruitment = _mapper.Map<Recruitment>(recruitmentViewModel);

            if (recruitmentViewModel.Photo != null)
            {
                var uploadResult = await _photoService.UploadImage(recruitmentViewModel.Photo, 600, 900);

                recruitment.PhotoUrl = uploadResult.ImageUrl;
                recruitment.PublicId = uploadResult.PublicId;
            }

            await _recruitRepo.CreateRecruitment(recruitment);

            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEdit(int id)
        {
            SetTitleAndActiveMenu("Edit a recruitment", ActiveMenu.Recruitment);

            var recruitment = await _recruitRepo.GetRecruitmentById(id);

            ViewData["Recruitment"] = recruitment;
            ViewData["EditMode"] = true;

            return View("GetCreate");
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> PostEdit(
            int id, 
            RecruitmentViewModel recruitmentViewModel
        )
        {
            SetTitleAndActiveMenu("Edit a recruitment", ActiveMenu.Recruitment);

            var updatedRecruitment = _mapper.Map<Recruitment>(recruitmentViewModel);
            var currentRecruitment = await _recruitRepo.GetRecruitmentById(id);
            
            if (recruitmentViewModel.Photo != null)
            {
                await _photoService.DeleteImage(currentRecruitment.PublicId);
                var uploadResult = await _photoService.UploadImage(recruitmentViewModel.Photo, 600, 900);

                updatedRecruitment.PhotoUrl = uploadResult.ImageUrl;
                updatedRecruitment.PublicId = uploadResult.PublicId;
            }

            await _recruitRepo.UpdateRecruitment(currentRecruitment, updatedRecruitment);

            return RedirectToAction("Index");
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteRecruitment(int id)
        {
            var currentRecruitment = await _recruitRepo.GetRecruitmentById(id);

            if (currentRecruitment.PublicId != null)
            {
                await _photoService.DeleteImage(currentRecruitment.PublicId);
            }

            await _recruitRepo.DeleteRecruitment(currentRecruitment);

            return RedirectToAction("Index");
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetSearch(string searchString)
        {
            SetTitleAndActiveMenu("Search recruitment", ActiveMenu.Recruitment);
            
            ViewData["Recruitments"] = await _recruitRepo.Search(searchString);

            return View("Index");
        }

        [HttpPost("{recruitmentId}/delete-apply/{id}")]
        public async Task<IActionResult> DeleteApply(int recruitmentId, int id)
        {            
            await _recruitRepo.RemoveAppliedPerson(id, recruitmentId);

            return RedirectToAction("GetEdit", new {id = recruitmentId});
        }
    }

}