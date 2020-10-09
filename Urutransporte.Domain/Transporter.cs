using System;

namespace Urutransporte.Domain
{
    public class Transporter
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public string CellPhone {get; set;}
        public string Website {get; set;}
        public string Description {get; set;}
        public double Rating {get; set;}
        public Transporter () {}

        public override bool Equals(object obj)
        {
            return this.Email.Equals(((Transporter)obj).Email);
        }
    }
}
