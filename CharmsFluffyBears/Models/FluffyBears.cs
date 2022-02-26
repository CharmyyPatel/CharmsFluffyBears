using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharmsFluffyBears.Models
{
    public class FluffyBears
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ProductName { get; set; }


        [Display(Name = "Product Description ")]
        [Required]
        public string ProductDescription { get; set; }

        [StringLength(30)]
        public string Size { get; set; }

        [StringLength(30)] 
        public string Colour { get; set; }

        [Range(1, 20)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}