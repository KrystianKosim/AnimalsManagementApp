using AnimalsManagementApp.Model;
using AnimalsManagementApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace AnimalsManagementApp.Controller;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalsService _animalsService;

    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }

    
    [HttpGet]
    public IActionResult GetAnimals([FromQuery(Name = "orderBy")] string orderBy)
    {
        var students = _animalsService.GetAnimals(orderBy);
        return Ok(students);
    }
    
    
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var affectedCount = _animalsService.UpdateAnimal(animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var affectedCount = _animalsService.DeleteAnimal(id);
        return NoContent();
    }
}