using System;

namespace Urutransporte.Domain
{
    public class City
    {
        public string Name {get; set;}
        
        public override bool Equals(object obj)
        {
            return this.Name.Equals(((City)obj).Name);
        }

        public City () {}
    }
}
