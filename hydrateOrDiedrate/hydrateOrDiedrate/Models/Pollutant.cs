using System;
using System.Collections.Generic;

namespace hydrateOrDiedrate.Models
{
    public class Pollutant
    {
        public int ID { get; set; }
        public string FirstName {get;set;}
        public string WaterBrand { get; set; }
        public string WaterSource { get; set; }
        
        public string Description { get; set; }
    }
}