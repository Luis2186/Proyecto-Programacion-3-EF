using System;
using System.Collections.Generic;
using System.Text;

namespace ComprasDTO
{
    public class FichaDTO
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string UnidadDeTiempo { get; set; }
        public decimal Temperatura { get; set; }
        public string TipoDeIluminacion { get; set; }

    }
}
