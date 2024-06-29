using GakkoHorizontalSlice.Model;

namespace GakkoHorizontalSlice.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals(string? orderBy);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int animalId);
}
