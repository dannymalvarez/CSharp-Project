using hydrateOrDiedrate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hydrateOrDiedrate.DAL
{
    public class WaterInitializers : System.Data.Entity. DropCreateDatabaseIfModelChanges<WaterContext>
    {
        protected /*override*/ void Seed(WaterContext context)
        {
            Pollutant pollutant = new Pollutant
            {
                
                
                FirstName="Daniel", WaterBrand="Dasani", WaterSource="Purified", Description="I enjoyed this water during my college years."
                
            };
            context.Pollutants.Add(pollutant);
            context.SaveChanges();
        }
    }
}