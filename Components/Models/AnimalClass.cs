using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Components.Models
{
    public class AnimalClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsWarmBlooded { get; set; }
        public string? MethodOfReproduction { get; set; }
        public ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}
