using System;
using System.Collections.Generic;

namespace ZeroXTeam.Entities
{
    public class Blog : BaseEntityWithPhoto
    {
        public string Brief { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Today;
        public DateTime UpdatedAt { get; set; } = DateTime.Today;
        public string Author { get; set; }
        public int Views { get; set; }
        public ICollection<UserComment> UserComments { get; set; }
    }
}