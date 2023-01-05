using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Praesent pulvinar justo lectus, non molestie nisi lobortis eget. Ut id nisl viverra ex tempus sodales molestie vel odio. Proin eu lectus erat. Maecenas scelerisque enim at massa dapibus congue. Integer elementum maximus vehicula.",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = ""
                }
                );
        }
    }
}
