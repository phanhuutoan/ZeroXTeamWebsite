using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Project : BaseEntityWithPhoto
    {
        public string Description { get; set; }
        public string Page { get; set; }
        public string Repository { get; set; }
        public DateTime StartDate { get; set; }
        public bool ShowForClient { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Member> MemberJoined { get; set; } = new List<Member>();
    }
}