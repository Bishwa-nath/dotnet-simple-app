using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBooksWeb.Models
{
    public class Category
    {
        [Key]       // Anotation - to make Id as Primary key
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Order must be between 1 to 100!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public Category()
        {

        }
    }
}
