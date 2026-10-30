using System.ComponentModel.DataAnnotations;

namespace Day3_DuongVietNam.Models
{
    public class Category
    {
        [Required (ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
