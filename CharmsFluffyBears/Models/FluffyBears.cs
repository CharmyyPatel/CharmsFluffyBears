using System;
using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

namespace CharmsFluffyBears.Models
{
    public class FluffyBears
    {
        public int Id { get; set; }

       // [Display(Name = "Product Name")]
        public string ProductName { get; set; }

       // [Display(Name = "Product Description ")]

        public string ProductDescription { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }

       // [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}