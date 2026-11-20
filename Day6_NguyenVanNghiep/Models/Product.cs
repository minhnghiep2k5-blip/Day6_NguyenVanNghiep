using System.ComponentModel.DataAnnotations;

namespace Day6_NguyenVanNghiep.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
