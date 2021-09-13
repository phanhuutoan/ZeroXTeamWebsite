using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Recruitment : BaseEntityWithPhoto
    {
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string Benefits { get; set; }
        public string Experience { get; set; }
        public string Location { get; set; }
        public string ContactWithUs { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastDay { get; set; }
        public ICollection<AppliedPerson> AppliedPeople { get; set; }
    }
}