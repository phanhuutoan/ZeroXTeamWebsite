using System.ComponentModel.DataAnnotations;

namespace ZeroXTeam.Entities
{
    public class HomePageInformation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string SubTitle { get; set; }
        public string HeroUrl { get; set; }
        public string HeroPublicId { get; set; }
        public string AboutUrl { get; set; }
        public string AboutPublicId { get; set; }
    }
}