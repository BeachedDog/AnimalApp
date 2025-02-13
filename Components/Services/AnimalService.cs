using System;
using System.Collections.Generic;
using AnimalApp.Components.Models;
using AnimalApp.Components.Pages;

namespace AnimalApp.Components.Services
{
    public class AnimalService
    {

        private static readonly Animal[] animals =
        [
            new Animal
            {
                Name = "Lion",
                AnimalClass = "Mammal",
                Description = "King of the jungle",
                Diet = "Carnivore",
                Colors = ["Golden", "Brown"],
                Weight = 200,
                NativeLocation = "Africa",
                Facts = ["Roars", "Fast"]
            },

            new Animal
            {
                Name = "Tiger",
                AnimalClass = "Mammal",
                Description = "Largest cat species",
                Diet = "Carnivore",
                Colors = ["Orange", "Black"],
                Weight = 220,
                NativeLocation = "Asia",
                Facts = ["Stripes", "Swims"]
            },

            new Animal
            {
                Name = "Elephant",
                AnimalClass = "Mammal",
                Description = "Largest land animal",
                Diet = "Herbivore",
                Colors = ["Gray", "Brown"],
                Weight = 6000,
                NativeLocation = "Africa, Asia",
                Facts = ["Trunk", "Tusks"]
            },

            new Animal
            {
                Name = "Giraffe",
                AnimalClass = "Mammal",
                Description = "Tallest land animal",
                Diet = "Herbivore",
                Colors = ["Yellow", "Brown"],
                Weight = 800,
                NativeLocation = "Africa",
                Facts = ["Long neck", "Spots"]
            },

            new Animal
            {
                Name = "Bear",
                AnimalClass = "Mammal",
                Description = "Large omnivorous mammal",
                Diet = "Omnivore",
                Colors = ["Brown", "Black", "White"],
                Weight = 500,
                NativeLocation = "North America, Europe, Asia",
                Facts = ["Hibernate", "Strong"]
            }
        ];

        public static Animal[] Animals => animals;

        public static Task<Animal[]> GetAnimalsAsync()
        {
            return Task.FromResult(Animals);
        }
    }
}