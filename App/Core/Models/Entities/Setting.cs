
using System.ComponentModel.DataAnnotations;
namespace Core.Models.Entities
{
    public class Setting : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        public int Type { get; set; }
    }
}
