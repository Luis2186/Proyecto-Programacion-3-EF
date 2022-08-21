using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class Tasas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
