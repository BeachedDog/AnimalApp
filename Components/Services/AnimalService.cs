using System;
using System.Collections.Generic;
using AnimalApp.Components.Data;
using AnimalApp.Components.Models;
using AnimalApp.Components.Pages;

namespace AnimalApp.Components.Services
{
    public class AnimalService
    {

        

        private static readonly Animal[] animals =
        [
            
        ];

        public static Animal[] Animals => animals;

        public static Task<Animal[]> GetAnimalsAsync(AnimalDataSeeder animals)
        {
            var animalList = animals.SeedAnimalData;
            var classList = animals.SeedClassData;
           
            return Task.FromResult(animalList);
        }
    }
}
// next i need to have CRUD that will push the seeded data into their respective database tables.
// After that, I need to look at the SQLite databases and 
//ensure they are there, then pull that data into the Services and have it displayed on the page. 