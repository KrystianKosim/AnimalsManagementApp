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

    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        if (orderBy == null)
        {
            orderBy = "name";
        }
        return _animalsRepository.GetAnimals(orderBy);
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalsRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int id)
    {
        return _animalsRepository.DeleteAnimal(id);
    }
}