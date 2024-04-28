using AnimalsManagementApp.Model;

namespace AnimalsManagementApp.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int id);
}