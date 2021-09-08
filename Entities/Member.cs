using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
        public string PublicId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedAt { get; set; }
        public ICollection<Project> ProjectJoined { get; set; } = new List<Project>();
    }
}