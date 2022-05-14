using Microsoft.EntityFrameworkCore;
using ApiTemperatura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTemperatura
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Temperaturas> Temperaturas { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

    }
}
