using Microsoft.AspNetCore.Http;

namespace ZeroXTeam.DTOs
{
    public class InformationDtos
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public IFormFile HeroImage { get; set; }
        public IFormFile AboutImage { get; set; }
    }
}