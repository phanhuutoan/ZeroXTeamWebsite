using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Member : BaseEntityWithPhoto
    {
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedAt { get; set; }
        public ICollection<Project> ProjectJoined { get; set; } = new List<Project>();
    }
}