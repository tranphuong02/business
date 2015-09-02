using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.Entities
{
    public class Post : BaseEntity
    {
        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string RawTitle { get; set; }

        public string Url { get; set; }

        [Required]
        [StringLength(500)]
        public string Keyword { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(1000)]
        public string Sumary { get; set; }

        [Required]
        [StringLength(1000)]
        public string RawSumary { get; set; }

        public string Content { get; set; }

        public string RawContent { get; set; }

        public string Image { get; set; }
        
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
