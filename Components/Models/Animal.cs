using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Components.Models
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? AnimalClass { get; set; }
        public string? Description { get; set; }
        public string? Diet { get; set; }
        public List<string>? Colors { get; set; }
        public int Weight { get; set; }
        public string? NativeLocation { get; set; }
        public List<string>? Facts { get; set; }

        public void SetAnimal(string name, string animalClass, string description, string diet,
            List<string> colors, int weight, string nativeLocation, List<string> facts)
        {
            Name = name;
            AnimalClass = animalClass;
            Description = description;
            Diet = diet;
            Colors = colors;
            Weight = weight;
            NativeLocation = nativeLocation;
            Facts = facts;
        }
    } 
    
}
