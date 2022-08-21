using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class NombreVulgar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Nombre Vulgar")]
        public string NomVulgar { get; set; }

        public NombreVulgar() { }

        public override string ToString()
        {
            return NomVulgar;
        }


    }
}
