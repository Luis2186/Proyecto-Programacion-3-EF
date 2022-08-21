using System;
using System.Collections.Generic;
using System.Text;


namespace ComprasDTO
{
    public class PlantaDTO
    {
        public int Id { get; set; }
        public TipoPlantaDTO Tipo { get; set; }     
        public string NombreCientifico { get; set; }
        public string NombresVulgares { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public decimal AlturaMaxima { get; set; }
        public string Foto { get; set; }
        public FichaDTO FichaDeCuidados { get; set; }   
        public decimal Precio { get; set; }

       
    }
}
