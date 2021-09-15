using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string Page { get; set; }
        public string Repository { get; set; }

        [Required]
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }
    }
}