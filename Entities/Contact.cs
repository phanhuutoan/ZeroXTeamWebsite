
using System;

namespace ZeroXTeam.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool HasRead {get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
}