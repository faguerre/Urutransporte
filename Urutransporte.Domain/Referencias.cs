using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Urutransporte.Domain
{
    [Table("Referencias")]
   public class Referencias
    {
        [Key]
        private int idReferencia;
        [ForeignKey("IdTransportista"),Column(Order =1)]
        private Transportista transportista;
        [StringLength(50),Required]
        private string nombre;
        [StringLength(50), Required]
        private string apellido;

        [StringLength(20), Required]
        private string celular;

        public Referencias(int idReferencia, Transportista transportista, 
            string nombre, string apellido, string celular)
        {
            IdReferencia = idReferencia;
            Transportista = transportista;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
        }

        public int IdReferencia { get => idReferencia; set => idReferencia = value; }
        public Transportista Transportista { get => transportista; set => transportista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Celular { get => celular; set => celular = value; }

        public override bool Equals(object obj)
        {
            return obj is Referencias referencias &&
                   IdReferencia == referencias.IdReferencia &&
                   EqualityComparer<Transportista>.Default.Equals(Transportista, referencias.Transportista) &&
                   Nombre == referencias.Nombre &&
                   Apellido == referencias.Apellido &&
                   Celular == referencias.Celular;
        }
    }
}
