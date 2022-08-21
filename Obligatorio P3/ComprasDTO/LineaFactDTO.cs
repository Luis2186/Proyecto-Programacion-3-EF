using System;
using System.Collections.Generic;
using System.Text;

namespace ComprasDTO
{
    public class LineaFactDTO
    {
        public int Id { get; set; }
        public int CantidadUnidadesCompradas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public PlantaDTO Planta { get; set; }
    }
}
