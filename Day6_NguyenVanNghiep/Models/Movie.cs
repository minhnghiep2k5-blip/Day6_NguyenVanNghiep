using System.ComponentModel.DataAnnotations;

namespace Day6_NguyenVanNghiep.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Range(1, 600)]
        public int Duration { get; set; }
        public int GenreId { get; set; }
    }
}
