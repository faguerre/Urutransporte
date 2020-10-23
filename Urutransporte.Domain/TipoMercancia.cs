using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Urutransporte.Domain
{   
    [Table("TipoMecancia")]
  public class TipoMercancia
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None),Column(Order =0)]
        private int idTipoMercancia;
        [StringLength(maximumLength:200),Column(Order =1)]
        private string descripcion;

        public TipoMercancia(int idTipoMercancia, string descripcion)
        {
            IdTipoMercancia = idTipoMercancia;
            Descripcion = descripcion;
        }

        public int IdTipoMercancia { get => idTipoMercancia; set => idTipoMercancia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoMercancia mercancia &&
                   IdTipoMercancia == mercancia.IdTipoMercancia &&
                   Descripcion == mercancia.Descripcion;
        }


        
    }
}
