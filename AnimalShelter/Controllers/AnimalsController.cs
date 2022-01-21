using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string type, string breed, int age, string gender, double weight)
    {
      var query = _db.Animals.AsQueryable();
      
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if(gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if(weight != 0.0)
      {
        query = query.Where(entry => entry.Weight == weight);
      }
      
      return await _db.Animals.ToListAsync();
    }

    //POST api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    //GET: api/Animals/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if(animal == null)
      {
        return NotFound();
      }

      return animal;
    }
  }
}