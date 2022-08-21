using System;
using System.Collections.Generic;
using System.Text;

namespace ComprasDTO
{
    public class CompraDTO
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public IEnumerable<LineaFactDTO> LineaFact { get; set; }   
        public decimal Total { get; set; }
        public decimal MontoImpuestos { get; set; }
        public string TipoDeCompra { get; set; }
        public decimal TasaIva { get; set; }
        public decimal CostoFlete { get; set; }
        public decimal ImpuestoImportacion { get; set; }
        public decimal TasaArancelaria { get; set; }
        public bool PerteneceAmericaDelSur { get; set; }
        public string MedidasSanitarias { get; set; }


    }
}
