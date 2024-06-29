namespace GakkoAppVertical.Animals;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals();
}
