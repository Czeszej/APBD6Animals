using GakkoHorizontalSlice.Model;
using GakkoHorizontalSlice.Repositories;

namespace GakkoHorizontalSlice.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;

    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals(string? orderBy)
    {
        var animals = _animalsRepository.GetAnimals(orderBy).ToList();
        return animals;
    }

    public int CreateAnimal(Animal animal)
    {

        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {

        return _animalsRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }

}
