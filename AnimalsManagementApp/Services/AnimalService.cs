using AnimalsManagementApp.Model;
using AnimalsManagementApp.Repositories;

namespace AnimalsManagementApp.Services;

public class AnimalService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;

    public AnimalService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        throw new NotImplementedException();
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }
}