using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; //sets instance to empty by default
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public Category? Category { get; set; } // adding foreign key for category
        public int CategoryId { get; set; }
    }
}
