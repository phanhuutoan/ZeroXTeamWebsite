using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.Models
{
    public class ApplyViewModel
    {
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string AboutMe { get; set; } // rich text

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public IFormFile CvFile {get; set;}
    }
}