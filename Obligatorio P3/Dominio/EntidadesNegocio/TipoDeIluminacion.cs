using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class TipoDeIluminacion : IValidacion
    {
       
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public TipoDeIluminacion() { }

        public override string ToString()
        {
            return Nombre;
        }

        public bool SoyValido()
        {
            return Nombre.Trim() != "";
        }
    }
}
