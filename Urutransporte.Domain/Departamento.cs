using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Urutransporte.Domain
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        private int idDepartamneto;
        [Column(Order = 1), StringLength(30), Required]
        private string nombreDepartamento;

        public Departamento(string nombreDepartamento, int idDepartamneto)
        {
            NombreDepartamento = nombreDepartamento;
            IdDepartamneto = idDepartamneto;
        }

        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
        public int IdDepartamneto { get => idDepartamneto; set => idDepartamneto = value; }

        public override bool Equals(object obj)
        {
            return obj is Departamento departamento &&
                   NombreDepartamento == departamento.NombreDepartamento &&
                   IdDepartamneto == departamento.IdDepartamneto;
        }
    }
}
