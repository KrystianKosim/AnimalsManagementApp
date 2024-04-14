using AnimalsManagementApp.Model;
using AnimalsManagementApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace AnimalsManagementApp.Controller;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalsService _animalsService;

    /// <summary>
    /// Endpoint used to create a animal.
    /// </summary>
    /// <param name="animal">New animal data</param>
    /// <returns>201 Created</returns>
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
}