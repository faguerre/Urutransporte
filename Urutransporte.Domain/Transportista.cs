using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Urutransporte.Domain
{
    [Table("Transportista")]
   public class Transportista
    {
        [Key]
        private int idTransportista;
       [Column(Order =1),StringLength(50),Required]
        private string nombre;
        [Column(Order = 2), StringLength(50), Required]
        private string direccion;
        [Column(Order = 3), ForeignKey("idDepartamento")]
        private  Departamento idDepartamento;
        [Column(Order = 4),ForeignKey("idCiudad")]
        private Ciudad idCiudad;
        [Column(Order = 5), StringLength(20), Required]
        private  string celular;
        [Column(Order = 6), StringLength(20), Required]
        private string telefono;
        [Column(Order = 7), StringLength(50), Required]
        private string paginaWeb;
        [Column(Order = 8), StringLength(50)]
        private string descripcion;
        [Column(Order =9)]
        private double valoracion;

        public Transportista(int idTransportista, string nombre, 
            string direccion, Departamento idDepartamento, Ciudad idCiudad, 
            string celular, string telefono, string paginaWeb, 
            string descripcion, double valoracion)
        {
            IdTransportista = idTransportista;
            Nombre = nombre;
            Direccion = direccion;
            IdDepartamento = idDepartamento;
            IdCiudad = idCiudad;
            Celular = celular;
            Telefono = telefono;
            PaginaWeb = paginaWeb;
            Descripcion = descripcion;
            Valoracion = valoracion;
        }

        public int IdTransportista { get => idTransportista; set => idTransportista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Departamento IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public Ciudad IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string PaginaWeb { get => paginaWeb; set => paginaWeb = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Valoracion { get => valoracion; set => valoracion = value; }

        public override bool Equals(object obj)
        {
            return obj is Transportista transportista &&
                   IdTransportista == transportista.IdTransportista &&
                   Nombre == transportista.Nombre &&
                   Direccion == transportista.Direccion &&
                   EqualityComparer<Departamento>.Default.Equals(IdDepartamento, transportista.IdDepartamento) &&
                   EqualityComparer<Ciudad>.Default.Equals(IdCiudad, transportista.IdCiudad) &&
                   Celular == transportista.Celular &&
                   Telefono == transportista.Telefono &&
                   PaginaWeb == transportista.PaginaWeb &&
                   Descripcion == transportista.Descripcion &&
                   Valoracion == transportista.Valoracion;
        }
    }
}
