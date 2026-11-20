using Day6_NguyenVanNghiep.Models;
using Microsoft.EntityFrameworkCore;

public class Day6_NguyenVanNghiepContext(DbContextOptions<Day6_NguyenVanNghiepContext> options) : DbContext(options)
{
    public DbSet<Day6_NguyenVanNghiep.Models.Product> Product { get; set; } = default!;
    public DbSet<Day6_NguyenVanNghiep.Models.Movie> Movie { get; set; } = default!;
    public DbSet<Day6_NguyenVanNghiep.Models.Genre> Genre { get; set; } = default!;

}
