using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsWebApiDemoProject.Model {
    public class MyAnimalDb : DbContext 
    {
        public DbSet<Animal> Animals { get; set; }

        public MyAnimalDb(DbContextOptions options) : base(options) { }


    }
}
