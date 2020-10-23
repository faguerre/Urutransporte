using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Urutransporte.Domain
{
    [Table("Cargador")]
    public class Cargador
    {
        [Key,Column(Order =0)]
        private int idCargador;

        [Column(Order =1),StringLength(20),Required]
        private string nombre;

        [Column(Order = 2), StringLength(30), Required]
        private string direccion;
        
        [Column(Order =3),ForeignKey("IdDepartamento")]
        private Departamento departamento;
        
        [Column(Order =4),ForeignKey("IdCiudad")]
        private Ciudad ciudad;
        
        [Column(Order = 5), StringLength(20), Required]
        private string celular;
        
        [Column(Order = 6), StringLength(20), Required]
        private string telefono;
        
        [Column(Order = 7), StringLength(30)]
        private string paginaWeB;
        
        [Column(Order = 8), StringLength(200), Required]
        private string descripcion;

        public Cargador(string nombre, string direccion, Departamento departamento, 
            Ciudad ciudad, string celular, string telefono, 
            string paginaWeB, string descripcion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Departamento = departamento;
            Ciudad = ciudad;
            Celular = celular;
            Telefono = telefono;
            PaginaWeB = paginaWeB;
            Descripcion = descripcion;
        }

        public int IdCargador { get => idCargador; set => idCargador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Departamento Departamento { get => departamento; set => departamento = value; }
        public Ciudad Ciudad { get => ciudad; set => ciudad = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string PaginaWeB { get => paginaWeB; set => paginaWeB = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override bool Equals(object obj)
        {
            return obj is Cargador cargador &&
                   IdCargador == cargador.IdCargador &&
                   Nombre == cargador.Nombre &&
                   Direccion == cargador.Direccion &&
                   EqualityComparer<Departamento>.Default.Equals(Departamento, cargador.Departamento) &&
                   EqualityComparer<Ciudad>.Default.Equals(Ciudad, cargador.Ciudad) &&
                   Celular == cargador.Celular &&
                   Telefono == cargador.Telefono &&
                   PaginaWeB == cargador.PaginaWeB &&
                   Descripcion == cargador.Descripcion;
        }
    }
}
