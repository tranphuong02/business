using System.ComponentModel.DataAnnotations;
namespace Core.Models.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public string SaltKey { get; set; }

        public int Role { get; set; }
    }
}
