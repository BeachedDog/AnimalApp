using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AnimalApp.Components.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public AnimalClass? AnimalClass { get; set; }
        public int AnimalClassId { get; set; }
        public string? Description { get; set; }
        public string? Diet { get; set; }

        public string ColorsJson { get; set; } = "[]";

        //EFcore has an issue with the handling of lists. After investigation, decided to serialize and deseriealize
        //information as Json to solve the issue. 

        [NotMapped]
        public List<string>? Colors 
        { 
            get => JsonSerializer.Deserialize<List<string>>(ColorsJson) ?? new List<string>();
            set => ColorsJson = JsonSerializer.Serialize(value); 
        }
        public string FactsJson { get; set; } = "[]";
        [NotMapped]
        public List<string>? Facts
        {
            get => JsonSerializer.Deserialize<List<string>>(FactsJson) ?? new List<string>();
            set => FactsJson = JsonSerializer.Serialize(value);
        }

        public double Weight { get; set; }
        public string? NativeLocation { get; set; }
        

    }
}
