using System.ComponentModel.DataAnnotations;

namespace Ecommerce_website.Models
{
    public class Registrartion
    {
        [Key]
        public int RegistrationId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}



