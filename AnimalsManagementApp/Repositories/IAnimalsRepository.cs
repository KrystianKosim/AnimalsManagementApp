using AnimalsManagementApp.Model;

namespace AnimalsManagementApp.Repositories;

public interface IAnimalsRepository
{
    public int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int id);

    IEnumerable<Animal> GetAnimals(string OrderBy);
}