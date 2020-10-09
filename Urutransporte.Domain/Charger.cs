using System;

namespace Urutransporte.Domain
{
    public class Charger
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public string CellPhone {get; set;}
        public string Website {get; set;}
        public string Description {get; set;}
        public State State { get; set;}
        public City City {get; set;}
        public Charger() {}

    }
}
