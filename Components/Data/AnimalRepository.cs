using AnimalApp.Components.Data;
using AnimalApp.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalApp.Components.Repositories
{
    public class AnimalRepository
    {
        private readonly AnimalAppContext _context;

        public AnimalRepository(AnimalAppContext context)
        {
            _context = context;
        }

        public async Task<List<Animal>> GetAllAnimalsAsync()
        {
            return await _context.Animals.ToListAsync();
        }

        public async Task<Animal?> GetAnimalByIdAsync(int id)
        {
            return await _context.Animals.FindAsync(id);
        }

        public async Task AddAnimalAsync(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAnimalAsync(Animal animal)
        {
            _context.Animals.Update(animal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnimalAsync(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal != null)
            {
                _context.Animals.Remove(animal);
                await _context.SaveChangesAsync();
            }
        }
    }
}
