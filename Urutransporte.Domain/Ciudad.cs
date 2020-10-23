using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Urutransporte.Domain
{
    [Table ("Ciudad")]
    public class Ciudad
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        private int idCiudad;
        [Column(Order = 1), StringLength(30), Required]
        private string nombreCiudad;

        public Ciudad(int idCiudad, string nombreCiudad)
        {
            IdCiudad = idCiudad;
            NombreCiudad = nombreCiudad;
        }

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        public override bool Equals(object obj)
        {
            return obj is Ciudad ciudad &&
                   IdCiudad == ciudad.IdCiudad &&
                   NombreCiudad == ciudad.NombreCiudad;
        }
    
    
    }
}
