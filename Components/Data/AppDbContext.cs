using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalApp.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalApp.Components.Data
{
    public class AnimalAppContext:DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalClass> AnimalClasses { get; set; }


        public AnimalAppContext(DbContextOptions<AnimalAppContext> options) : base(options) { }
    }
}
