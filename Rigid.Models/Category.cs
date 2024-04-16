using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rigid.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
		[DisplayName("Category Name")]
		public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="1-100 is the allowed range for the Display Order")]
        public int DisplayOrder { get; set; }
    }
}
