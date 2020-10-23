using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Urutransporte.Domain
{
    [Table("Transporte")]
   public class Transporte
    {
        [Key,Column(Order =0)]
        private int idTransporte;
        [Column(Order =1),ForeignKey("IdTransportista"),Required]
        private Transportista idTransportista;
        [Column(Order = 2), ForeignKey("IdTipoTransporte"),Required]
        private TipoTransporte idTipoTransporte;
        [Column(Order = 3), ForeignKey("IdTipoMercancia"), Required]
        private TipoMercancia idTipoMercancia;
        [Column(Order = 4), Required]
        private int year;
        [Column(Order = 5), Required]
        private double largo;
        [Column(Order = 6), Required]
        private double ancho;
        [Column(Order = 7), Required]
        private double alto;
        [Column(Order = 8), Required]
        private string matricula;

        public Transporte(Transportista idTransportista, TipoTransporte idTipoTransporte, TipoMercancia idTipoMercancia, int year, double largo, double ancho, double alto, string matricula)
        {
            IdTransportista = idTransportista;
            IdTipoTransporte = idTipoTransporte;
            IdTipoMercancia = idTipoMercancia;
            Year = year;
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
            Matricula = matricula;
        }

        public int IdTransporte { get => idTransporte; set => idTransporte = value; }
        public Transportista IdTransportista { get => idTransportista; set => idTransportista = value; }
        public TipoTransporte IdTipoTransporte { get => idTipoTransporte; set => idTipoTransporte = value; }
        public TipoMercancia IdTipoMercancia { get => idTipoMercancia; set => idTipoMercancia = value; }
        public int Year { get => year; set => year = value; }
        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public double Alto { get => alto; set => alto = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public override bool Equals(object obj)
        {
            return obj is Transporte transporte &&
                   IdTransporte == transporte.IdTransporte &&
                   EqualityComparer<Transportista>.Default.Equals(IdTransportista, transporte.IdTransportista) &&
                   EqualityComparer<TipoTransporte>.Default.Equals(IdTipoTransporte, transporte.IdTipoTransporte) &&
                   EqualityComparer<TipoMercancia>.Default.Equals(IdTipoMercancia, transporte.IdTipoMercancia) &&
                   Year == transporte.Year &&
                   Largo == transporte.Largo &&
                   Ancho == transporte.Ancho &&
                   Alto == transporte.Alto &&
                   Matricula == transporte.Matricula;
        }
    }
}
