using Countries.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Data
{
    public class CountriesDbContext : DbContext
    {
        public CountriesDbContext()
            : base("CountriesSystem")
        {
        }

        public virtual DbSet<Continent> Continents { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        public static CountriesDbContext Create()
        {
            return new CountriesDbContext();
        }
    }
}
