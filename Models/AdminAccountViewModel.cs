using System.ComponentModel.DataAnnotations;

namespace ZeroXTeam.Entities
{
    public class AdminAccountViewModel
    {   
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
    }
}