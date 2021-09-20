using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Member : BaseEntityWithPhoto
    {
        public string TeamTitles { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool ShowForClient { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }
        public ICollection<Project> ProjectJoined { get; set; } = new List<Project>();
    }
}