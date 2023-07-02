using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models 
{
    public class AnimalShelterApiContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                builder.Entity<Animal>()
                    .HasData(
                        new Animal { AnimalId = 1, Species = "Dog", Name = "Barley", Breed = "Mixed", Age = 4 },
                        new Animal { AnimalId = 2, Species = "Cat", Name = "Pancake", Breed = "American Shorthair", Age = 6 },
                        new Animal { AnimalId = 3, Species = "Dog", Name = "Rory", Breed = "Terrier", Age = 2 },
                        new Animal { AnimalId = 4, Species = "Cat", Name = "Fil", Breed = "Maine Coon", Age = 8 },
                        new Animal { AnimalId = 5, Species = "Dog", Name = "Tugger", Breed = "Shi-Tzu", Age = 9 },
                        new Animal { AnimalId = 6, Species = "Dog", Name = "Ody", Breed = "American Bull Terrier", Age = 1 }
                    );
            }
        }
    }
}