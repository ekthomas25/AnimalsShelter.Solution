using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [EnableCors("mypolicy")]
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Returns all animals with the specific query parameters.
    /// </summary>
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

    /// <summary>
    /// Adds an Animal to the API.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    /// <summary>
    /// Returns a specific Animal by Id.
    /// </summary>
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

    /// <summary>
    /// Edits a specific Animal.
    /// </summary>
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch(DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    /// <summary>
    /// Deletes a specific Animal.
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}