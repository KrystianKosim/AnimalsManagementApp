using AnimalsManagementApp.Model;

namespace AnimalsManagementApp.Repositories;

public interface IAnimalsRepository
{
    public int CreateAnimal(Animal animal);
}