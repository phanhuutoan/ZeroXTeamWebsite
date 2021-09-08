using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.Entities;
using ZeroXTeam.Models;
using ZeroXTeam.Services;
using ZeroXTeam.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/information")]
    [Authorize]
    public class AdminInformationController : AdminControllerBase
    {
    private readonly InformationRepository _informationRepo;
    private readonly PhotoUploadService _photoService;

    public AdminInformationController(
            InformationRepository informationRepository, 
            IMapper mapper,
            PhotoUploadService photoUploadService    
        ) : base(mapper)
        {
            _informationRepo = informationRepository;
            _photoService = photoUploadService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Landing page information";
            ViewData["ActiveMenu"] = "information";

            var data = await _informationRepo.GetInformation();

            var viewData = new InformationViewModel();

            if (data != null)
            {
                viewData = _mapper.Map<InformationViewModel>(data);
                ViewData["InformationData"] = viewData;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInformation(InformationDtos informationDtos)
        {
            var information = new HomePageInformation();
            var existingInformation = await _informationRepo.GetInformation();

            information.Title = informationDtos.Title;
            information.SubTitle = informationDtos.SubTitle;

            if (informationDtos.HeroImage?.Length > 0)
            {
                if (existingInformation != null) await _photoService.DeleteImage(existingInformation.HeroPublicId);
                var uploadResult = await _photoService.UploadImage(informationDtos.HeroImage);
                information.HeroPublicId = uploadResult.PublicId;
                information.HeroUrl = uploadResult.ImageUrl;
            }

            if (informationDtos.AboutImage?.Length > 0)
            {
                if (existingInformation != null) await _photoService.DeleteImage(existingInformation.AboutPublicId);
                var uploadResult = await _photoService.UploadImage(informationDtos.AboutImage, 400, 500);
                information.AboutPublicId = uploadResult.PublicId;
                information.AboutUrl = uploadResult.ImageUrl;
            }

            var data = await _informationRepo.UpdateInformation(information);

            if (data) 
            {
                TempData["MessageSuccess"] = "Update Successfully";
            }
            else 
            {
                TempData["MessageFail"] = "Update Failed";
            }
            
            return RedirectToAction("Index");
        }
    }
}