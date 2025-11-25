using System.ComponentModel.DataAnnotations;

namespace eCommerce_Shop_Client.Models
{
    public class Testimonial
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Reviewer_Name { get; set; }
        [Required(ErrorMessage = "Please write a review")]
        public string? Review_Text { get; set; }
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Star { get; set; }
    }
}
