﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
