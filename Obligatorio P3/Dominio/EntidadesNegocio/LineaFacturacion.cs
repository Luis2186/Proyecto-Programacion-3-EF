using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class LineaFacturacion : IValidacion 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar la cantidad de Plantas")]
        public int Cantidad { get; set; }
        public Planta Planta { get; set; }
        public Compra Compra { get; set; }
        [Required(ErrorMessage = "Debe ingresar la Planta que quiere comprar")]
        public int PlantaId { get; set; }
        public int CompraId { get; set; }
        public decimal PrecioUnitario { get; set; }

        public LineaFacturacion() { }

        public bool SoyValido()
        {
            bool valido = false;
            if (Planta != null && Compra != null && Cantidad > 0 && PlantaId != 0 && CompraId != 0)
            {
                valido = true;
            }
            return valido;
        }

        public decimal CalcularPrecioUnitario()
        {
            PrecioUnitario= Compra.CalcularPrecioCompra(Planta.Precio * Cantidad);            
            return PrecioUnitario;
        }





    }
}
