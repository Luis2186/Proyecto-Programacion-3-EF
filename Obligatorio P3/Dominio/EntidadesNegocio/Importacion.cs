using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class Importacion : Compra
    {
        
        public static decimal ImpuestoImportacion { get; set; }
        [Required(ErrorMessage = "Debe ingresar las medidas sanitarias")]
        public string MedidasSanitarias { get; set; }
        [Required(ErrorMessage = "Debe ingresar si la importacion pertenece a America Del Sur")]
        public bool AmericaDelSur { get; set; }
      
        public static decimal TasaArancelaria { get; set; }

        public Importacion() { }

        public override decimal CalcularPrecioCompra(decimal precio)
        {
            decimal precioFinal = (ImpuestoImportacion / 100 + 1) * precio;
            decimal descuentoADS= (TasaArancelaria / 100) * precio;

            if (AmericaDelSur == true) { 
                precioFinal = precioFinal - descuentoADS;
            }

            return precioFinal;
        }

        public override string DefinirCompra()
        {
            return "Importacion";
        }

    }
}
