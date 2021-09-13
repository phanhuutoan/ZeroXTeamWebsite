using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.Models
{
    public class RecruitmentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public IFormFile Photo { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Requirements { get; set; }

        [Required]
        public string Benefits { get; set; }
        public string Experience { get; set; }
        public string Location { get; set; }
        public string ContactWithUs { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime LastDay { get; set; }
    }
}