using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimalsApi.Model;

namespace AnimalsApi.Data
{
    public class AnimalsApiContext : DbContext
    {
        public AnimalsApiContext (DbContextOptions<AnimalsApiContext> options)
            : base(options)
        {
        }

        public DbSet<AnimalsApi.Model.Animal> Animal { get; set; } = default!;
    }
}
