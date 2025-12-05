using System.ComponentModel.DataAnnotations;

namespace eCommerce_Shop_Client.Models
{
    public class Contact
    {
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        public string? Full_Name { get; set; }
        public string? Email { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Message cannot be empty")]
        public string? Message { get; set; }
    }
}
