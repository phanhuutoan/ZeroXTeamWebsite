using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ZeroXTeam.Data;
using ZeroXTeam.Entities;
using ZeroXTeam.Models;
using System.Web;
using AutoMapper;

namespace ZeroXTeam.Controllers
{
    [Route("admin")]
    public class AdminHomeController : AdminControllerBase
    {
    private readonly AdminRepository _adminRepo;

        public AdminHomeController(AdminRepository adminRepository, IMapper mapper) : base(mapper)         
        {
            _adminRepo = adminRepository;
        }

        public IActionResult Index([FromQuery] string ReturnUrl)
        {
            ViewData["Title"] = "Home"; 
            TempData["ReturnUrl"] = ReturnUrl;
            
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterPost(AdminAccountViewModel account) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Your data is invalid");
            }

            if (await _adminRepo.AnyAdminAsync())
            {
                TempData["ValidError"] = "Only one admin can be register this way";
                return RedirectToAction("register");
            }

            using var hmac = new HMACSHA256();

            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(account.Password));
            var passwordSalt = hmac.Key;
            
            var adminAccount = new AdminAccount() 
            {
                Name = account.Name,
                Email = account.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _adminRepo.CreateAdmin(adminAccount);

            await _adminRepo.SaveAllChangeAsync();

            return RedirectToAction("index", "AdminHome");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginPost(LoginViewModel loginData)
        {
            var user = await _adminRepo.GetAdminAccountByEmailAsync(loginData.Email);

            if (user == null)
            {
                TempData["ValidError"] = "This user does not exist";
                return RedirectToAction("Index");
            }

            using var hmac = new HMACSHA256(user.PasswordSalt);

            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginData.Password));

            if (!ComparePassword(passwordHash, user.PasswordHash))
            {
                TempData["ValidError"] = "Password is invalid";
                return RedirectToAction("Index");
            }

            await SignInWithClaim(user.Email);

            return string.IsNullOrEmpty(loginData.ReturnUrl) ?
                RedirectToAction("Index") :
                Redirect(HttpUtility.UrlDecode(loginData.ReturnUrl));
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogoutPost()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index");
        }

        private bool ComparePassword(byte[] oldPass, byte[] currentPass)
        {   
            for(var i = 0; i < oldPass.Length; i++)
            {
                if (oldPass[i] != currentPass[i]) return false;
            }

            return true;
        }

        private async Task SignInWithClaim(string email)
        {
            var claims = new List<Claim>() 
            {
                new Claim("Email", email),
                new Claim(ClaimTypes.NameIdentifier, email)
            };

            var claimPrincipal = new ClaimsPrincipal();
            var ClaimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            claimPrincipal.AddIdentity(ClaimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal);
        }
    }
}