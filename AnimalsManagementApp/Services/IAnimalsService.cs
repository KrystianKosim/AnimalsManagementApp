using AnimalsManagementApp.Model;

namespace AnimalsManagementApp.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal animal);
}