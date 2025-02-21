using System.ComponentModel.DataAnnotations;

namespace Ecommerce_website.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? ProductDescription { get; set;}
        [Required]
        public string? ProductPrice { get; set; }
        [Required]
        public string? ProductType { get; set;}
    }
}
