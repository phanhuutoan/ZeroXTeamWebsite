using System;

namespace ZeroXTeam.Entities
{
    public class AppliedPerson 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AboutMe { get; set; } // rich text
        public string Email { get; set; }
        public string Phone { get; set; }
        public Recruitment Recruitment { get; set; }
        public int RecruitmentId { get; set; }
    }
}