using System.ComponentModel.DataAnnotations;

namespace ZeroXTeam.Entities
{
    public abstract class BaseEntityWithPhoto : BaseEntity
    {        
        [Required]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string PublicId { get; set; }
    }
}