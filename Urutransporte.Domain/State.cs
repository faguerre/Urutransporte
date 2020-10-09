using System;

namespace Urutransporte.Domain
{
    public class State
    {
        public string Name {get; set;}

        public State () {}
        
        public override bool Equals(object obj)
        {
            return this.Name.Equals(((City)obj).Name);
        }
    }
}
