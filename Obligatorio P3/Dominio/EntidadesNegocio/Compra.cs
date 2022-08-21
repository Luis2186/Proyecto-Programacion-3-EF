using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public abstract class Compra : IValidacion
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar la fecha de la compra")]
        public DateTime Fecha { get; set; }
        public List<LineaFacturacion> PlantaCompra { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; } 

        public abstract decimal CalcularPrecioCompra(decimal precio);
        public abstract string DefinirCompra();
        
        public bool SoyValido()
        {
            
            foreach (LineaFacturacion lnF in PlantaCompra)
            {
                if (lnF.PlantaId == 0)
                {
                    return false;
                }
            }
            return Fecha != null;
        }

        public decimal CalcularTotalFinal()
        {
            decimal total = 0;
            bool fleteSumado = false;
            foreach (LineaFacturacion lnF in PlantaCompra)
            {             
                lnF.CalcularPrecioUnitario();
                total += lnF.PrecioUnitario;

                if (lnF.Compra is Plaza && !fleteSumado && (lnF.Compra as Plaza).CostoFlete != 0)
                {  
                    total += (lnF.Compra as Plaza).CostoFlete;
                    fleteSumado = true;
                }      
            }    
                return Total= total;
        }

        public void CalcularSubTotal()
        {
            foreach (LineaFacturacion lnF in PlantaCompra)
            {
                SubTotal += lnF.Cantidad * lnF.Planta.Precio;
            }   
        }

    }
}
