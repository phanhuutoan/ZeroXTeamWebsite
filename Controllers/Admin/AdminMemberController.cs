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
    [Route("/admin/members")]
    [Authorize]
    public class AdminMemberController : AdminControllerBase
    {
        private readonly PhotoUploadService _photoService;
        private readonly MemberRepository _memberRepo;

        public AdminMemberController(
            IMapper mapper, 
            MemberRepository memberRepository, 
            PhotoUploadService photoUploadService) : base(mapper)
        {
            _photoService = photoUploadService;
            _memberRepo = memberRepository;
        }

        public async Task<IActionResult> Index(PaginationParams paginationParams)
        {
            SetTitleAndActiveMenu("Members", ActiveMenu.Member);

            var members = await _memberRepo.GetMembers(paginationParams);

            ViewData["Members"] = members;

            return View();
        }

        [HttpGet("create")]
        public IActionResult GetCreate()
        {
            SetTitleAndActiveMenu("Members", ActiveMenu.Member);

            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> PostCreate(MemberViewModel memberViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid data");

            var member = _mapper.Map<Member>(memberViewModel);

            if (memberViewModel.Photo != null)
            {
                var uploadResult = await _photoService.UploadImage(memberViewModel.Photo, 400, 400);

                member.PhotoUrl = uploadResult.ImageUrl;
                member.PublicId = uploadResult.PublicId;
            }

            if (await _memberRepo.AddMember(member)) return RedirectToAction("Index");

            return BadRequest("Update failed");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEdit(int id)
        {
            SetTitleAndActiveMenu("Members", ActiveMenu.Member);

            var member = await _memberRepo.GetMemberById(id);

            ViewData["Member"] = member;
            ViewData["EditMode"] = true;

            return View("GetCreate");
        }

        [HttpPost("edit")]
        public async Task<IActionResult> PostEdit(MemberViewModel memberViewModel)
        {
            var member = await _memberRepo.GetMemberById(memberViewModel.Id);
            var updatedMember = _mapper.Map<Member>(memberViewModel);

            if (memberViewModel.Photo != null)
            {
                if (member != null) await _photoService.DeleteImage(member.PublicId);
                var uploadResult = await _photoService.UploadImage(memberViewModel.Photo, 400, 400);
                member.PublicId = uploadResult.PublicId;
                member.PhotoUrl = uploadResult.ImageUrl;
            }

            if (await _memberRepo.UpdateMember(member, updatedMember)) return RedirectToAction("Index");

            return BadRequest("Update failed");
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var member = await _memberRepo.GetMemberById(id);

            if (member.PhotoUrl != null)
            {
                if (member != null) await _photoService.DeleteImage(member.PublicId);
            }

            if (await _memberRepo.DeleteMember(member)) return Ok();

            return BadRequest("Delete failed");
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetSearch(string searchString)
        {
            SetTitleAndActiveMenu("Search members", ActiveMenu.Member);
            
            ViewData["Members"] = await _memberRepo.Search(searchString);

            return View("Index");
        }
    }


}