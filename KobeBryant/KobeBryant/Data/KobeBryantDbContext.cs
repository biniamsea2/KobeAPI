using KobeBryant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Data
{
    public class KobeBryantDbContext : DbContext
    {
        public KobeBryantDbContext(DbContextOptions<KobeBryantDbContext> options) : base(options)
        {

        }



        public DbSet<Kobe> Records { get; set; }

    }
}
