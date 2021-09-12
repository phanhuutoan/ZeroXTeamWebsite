using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.Models
{
    public class BlogViewModel
    {
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
        public string Brief { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}