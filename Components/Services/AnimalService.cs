using AnimalApp.Components.Models;
using AnimalApp.Components.Repositories;

namespace AnimalApp.Components.Services
{
    public class AnimalService
    {
        private readonly AnimalRepository _repository;

        public AnimalService(AnimalRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Animal>> GetAnimalsAsync()
        {
            return _repository.GetAllAnimalsAsync();
        }

        public Task<Animal?> GetAnimalAsync(int id)
        {
            return _repository.GetAnimalByIdAsync(id);
        }

        public Task AddAnimalAsync(Animal animal)
        {
            return _repository.AddAnimalAsync(animal);
        }

        public Task UpdateAnimalAsync(Animal animal)
        {
            return _repository.UpdateAnimalAsync(animal);
        }

        public Task DeleteAnimalAsync(int id)
        {
            return _repository.DeleteAnimalAsync(id);
        }
    }
}
