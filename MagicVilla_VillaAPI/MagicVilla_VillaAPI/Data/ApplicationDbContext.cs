using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Test1",
                    Details = "lorem ipsum",
                    ImageUrl = "http://dotnetmasteryimages.blob.core.windows.net/bluevillaimagse/villa3.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = ""

                },
                 new Villa()
                 {
                     Id = 2,
                     Name = "Test2",
                     Details = "lorem ipsum",
                     ImageUrl = "http://dotnetmasteryimages.blob.core.windows.net/bluevillaimagse/villa3.jpg",
                     Occupancy = 6,
                     Rate = 300,
                     Sqft = 650,
                     Amenity = ""

                 });
        }
    }
}
