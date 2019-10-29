using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grocery.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
