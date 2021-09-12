using System;

namespace ZeroXTeam.Entities
{
    public class UserComment
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Today;
        public DateTime UpdatedAt { get; set; } = DateTime.Today;
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}