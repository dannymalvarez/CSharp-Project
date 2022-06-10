using hydrateOrDiedrate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace hydrateOrDiedrate.DAL
{
    public class WaterContext : DbContext
    {
        public WaterContext() : base("WaterContext")
        {
        }

        public DbSet<Pollutant> Pollutants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}