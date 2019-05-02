using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAdoNet
{
    class CountryContext : DbContext
    {
        public CountryContext()
            :base("DbConnection")
        { }

        public DbSet<Country> Countryes { get; set; }
        public DbSet<City> Cityes { get; set; }
        public DbSet<Street> Streets { get; set; }

    }
}
