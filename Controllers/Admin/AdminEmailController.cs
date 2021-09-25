using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ZeroXTeam.Data;
using ZeroXTeam.DTOs;
using ZeroXTeam.Helpers;

namespace ZeroXTeam.Controllers.Admin
{
    [Route("/admin/email")]
    [Authorize]
    public class AdminEmailController : AdminControllerBase
    {
        private ContactRepository _contactRepo;
        private IMemoryCache _cache;

    private bool _isRead {get; set;}

        public AdminEmailController(
            IMapper mapper,
            ContactRepository contactRepository,
            IMemoryCache cache
        ) : base(mapper)
        {
            _contactRepo = contactRepository;
            _cache = cache;
        }

        public async Task<IActionResult> Index(PaginationParams paginationParams, bool? IsRead)
        {
            SetTitleAndActiveMenu("Contact letter", ActiveMenu.Email);
            _cache.Set<PaginationParams>("paginationParams", paginationParams);

            if (IsRead == null) {
                IsRead = _cache.Get<bool>("isRead");
            }

            ViewData["ContactLetters"] = await _contactRepo.GetContactLetters(paginationParams, IsRead);

            ViewData["IsRead"] = IsRead;
            _cache.Set<bool>("isRead", (bool)IsRead);
            
            return View();
        }
        
        [HttpGet("read/{id}")]
        public async Task<IActionResult> Read(int id)
        {
            SetTitleAndActiveMenu("Contact letter", ActiveMenu.Email);
            var letter = await _contactRepo.GetContactLetter(id);
            ViewData["Letter"] = letter;

            await _contactRepo.UpdateReadStatus(letter);
            
            return View();
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var contactLetter = await _contactRepo.GetContactLetter(id);
            var result = await _contactRepo.DeleteContactLetter(contactLetter);

            var paginationParams = _cache.Get<PaginationParams>("paginationParams");
            var isRead = _cache.Get<bool>("isRead");

            if (result) return RedirectToAction("Index", new {
                ItemPerPage = paginationParams.ItemPerPage,
                PageNumber = paginationParams.PageNumber,
                SortBy = paginationParams.SortBy,
                IsRead = isRead
            });

            return BadRequest("Failed to delete");
        }
    }
}