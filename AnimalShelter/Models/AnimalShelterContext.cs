using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Bart", Type = "Cat", Breed = "Scottish Fold", Color = "Grey", Age = 4, Gender = "Male", Weight = 7, Location = "The Cattery" },
          new Animal { AnimalId = 2, Name = "Indy", Type = "Cat", Breed = "Russian Blue", Color = "Grey", Age = 16, Gender = "Male", Weight = 8.3, Location = "The Cattery" },
          new Animal { AnimalId = 3, Name = "Peeve", Type = "Cat", Breed = "American Shorthair", Color = "Black", Age = 8, Gender = "Male", Weight = 6.9, Location = "The Cattery" },
          new Animal { AnimalId = 4, Name = "Buzz", Type = "Cat", Breed = "American Shorthair", Color = "Tabby", Age = 16, Gender = "Male", Weight = 7.8, Location = "The Cattery" },
          new Animal { AnimalId = 5, Name = "Lily", Type = "Cat", Breed = "Maine Coon", Color = "Orange and White", Age = 9, Gender = "Female", Weight = 8.8, Location = "The Cattery" },
          new Animal { AnimalId = 6, Name = "Pete", Type = "Dog", Breed = "Australian Cattle Dog Mix", Color = "Black and White", Age = 5, Gender = "Male", Weight = 43, Location = "The Blue Room" },
          new Animal { AnimalId = 7, Name = "Buster", Type = "Dog", Breed = "Hound", Color = "Brown", Age = 6, Gender = "Male", Weight = 55.7, Location = "The Red Room" },
          new Animal { AnimalId = 8, Name = "Amy", Type = "Dog", Breed = "Golden Retriever", Color = "Brown", Age = 4, Gender = "Female", Weight = 61.5, Location = "The Red Room" },
          new Animal { AnimalId = 9, Name = "Lucy", Type = "Dog", Breed = "Australian Shepherd", Color = "Black and White", Age = 3, Gender = "Female", Weight = 38.7, Location = "The Blue Room" },
          new Animal { AnimalId = 10, Name = "Jazz", Type = "Dog", Breed = "Maltese", Color = "White", Age = 8, Gender = "Female", Weight = 15.6, Location = "The Yellow Room" },
          new Animal { AnimalId = 11, Name = "Xena", Type = "Dog", Breed = "Pomperdoodle", Color = "Black", Age = 9, Gender = "Female", Weight = 14.8, Location = "The Yellow Room" },
          new Animal { AnimalId = 12, Name = "Oliver", Type = "Dog", Breed = "Goldendoodle", Color = "Brown", Age = 1, Gender = "Male", Weight = 23, Location = "The Red Room" }
        );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}