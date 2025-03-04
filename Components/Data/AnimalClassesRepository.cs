using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalApp.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalApp.Components.Data
{
    public class AnimalClassRepository
    {
        private readonly AnimalAppContext _context;

        public AnimalClassRepository(AnimalAppContext context)
            {
            _context = context;
            }

        public async Task<List<AnimalClass>> GetAllAnimalClassesAsync()
        {
            return await _context.AnimalClasses.ToListAsync();

        }

        public async Task<AnimalClass?> GetAnimalClassByIDAsync(int Id)
        {
            return await _context.AnimalClasses.FindAsync(Id);
        }
        public async Task UpdateAnimalClassAsync(AnimalClass animalClass)
        {
            _context.AnimalClasses.Update(animalClass);
            await _context.SaveChangesAsync();
        }

        public async Task AddAnimalClassAsync(AnimalClass animalClass)
        {
            _context.AnimalClasses.Add(animalClass);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnimalClassAsync(int id)
        {
            var animal = await _context.AnimalClasses.FindAsync(id);
                if (animal != null)
            {
                _context.AnimalClasses.Remove(animal);
                await _context.SaveChangesAsync();
            }
        }
    }
}
