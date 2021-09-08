using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string PublicId { get; set; }
        public string Description { get; set; }
        public string Page { get; set; }
        public string Repository { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Member> MemberJoined { get; set; } = new List<Member>();
    }
}