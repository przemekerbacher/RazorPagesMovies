using System.ComponentModel.DataAnnotations;

namespace Grocery.Models
{
    public class DiscountedProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal NewPrice { get; set; }

        public int ProductId { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}
