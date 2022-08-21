using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class Plaza : Compra
    {
   
        public static decimal TasaIva { get; set; }
        [Required]
        public decimal CostoFlete { get; set; }

        public override decimal CalcularPrecioCompra(decimal precio)
        {
            decimal precioFinal= (TasaIva / 100 + 1) * precio;

            return precioFinal;
        }

        public override string DefinirCompra()
        {
            return "Plaza";
        }

    }
}
