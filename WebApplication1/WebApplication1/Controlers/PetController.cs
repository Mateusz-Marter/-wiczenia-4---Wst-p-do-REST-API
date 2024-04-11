using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controlers;

[ApiController]
[Route("api/pets")]
public class PetController : ControllerBase
{
    [HttpGet("")]
    public IActionResult getAllPets()
    {
        return Ok(Db.pets);
    }

    [HttpGet("{id:int}")]
    public IActionResult getPetsById(int id)
    {
        return Ok(Db.pets.Find(pet => pet.Id == id));
    }

    [HttpGet("{id:int}/visits")]
    public IActionResult getPetVisits(int id)
    {
        List<VetVisit> visitList = new();

        foreach (var visit in Db.Visits)
        {
            if (visit.PetId == id)
            {
                visitList.Add(visit);
            }
        }

        return Ok(visitList);
    }

    [HttpPut("{id:int}")]
    public IActionResult updatePet(int id, Pet pet)
    {

        foreach (var p in Db.pets)
        {
            if (p.Id == id)
            {
                p.Name = pet.Name;
                p.Category = pet.Category;
                p.Weight = pet.Weight;
                p.Colour = pet.Colour;

                return Ok();
            }
        }
        
        return NotFound("No pet found in database!");
    }

    [HttpPost("")]
    public IActionResult addPet(Pet pet)
    {
        Db.pets.Add(pet);

        //Console.WriteLine(Db.pets[^1]);

        return Ok();
    }

    [HttpPost("{id:int}/visits")]
    public IActionResult addVisit(int id, VetVisit visit)
    {
        visit.PetId = id;
        Db.Visits.Add(visit);

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public IActionResult deletePet(int id)
    {
        Pet? pet = Db.pets.Find(pet => pet.Id == id);
        if (pet != null)
        {
            Db.pets.Remove(pet);
            return Ok();
        }

        return NotFound();
    }
}