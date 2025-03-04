using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<string>? Colors { get; set; }
        public double Weight { get; set; }
        public string? NativeLocation { get; set; }
        public List<string>? Facts { get; set; }

    }
}
