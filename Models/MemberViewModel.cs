using System;
using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeamTitles { get; set; }
        public string Bio { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public DateTime JoinedAt { get; set; }
    }
}