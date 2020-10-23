using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Urutransporte.Domain
{
    [Table ("TipoTransporte")]
 public  class TipoTransporte
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 0)]
        private int idTipoTransporte;
        [StringLength(maximumLength: 200), Column(Order = 1)]
        private string descripcion;

        public TipoTransporte(int idTipoTransporte, string descripcion)
        {
            IdTipoTransporte = idTipoTransporte;
            Descripcion = descripcion;
        }

        public int IdTipoTransporte { get => idTipoTransporte; set => idTipoTransporte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoTransporte transporte &&
                   IdTipoTransporte == transporte.IdTipoTransporte &&
                   Descripcion == transporte.Descripcion;
        }
    }
}
