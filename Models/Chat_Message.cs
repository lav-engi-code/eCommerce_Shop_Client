using System.ComponentModel.DataAnnotations;

namespace eCommerce_Shop_Client.Models
{
    public class Chat_Message
    {
        [Required]
        public string Chat { get; set; }
        public string Response { get; set; }
    }
}
