using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class FichaDeCuidado : IValidacion
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar la cantidad de unidad de tiempo")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "Debe ingresar la unidad de tiempo")]
        public string UnidadDeTiempo { get; set; }
        [Required(ErrorMessage = "Debe ingresar la temperatura")]
        public decimal Temperatura { get; set; }
        public TipoDeIluminacion TipoDeIluminacion { get; set; }

        public FichaDeCuidado() { }

        public bool SoyValido()
        {
            bool soyValido = false;
            if (Cantidad > 0 && UnidadDeTiempo.Trim() != "")
            {
                soyValido = true;
            }
            return soyValido;
        }

        public override string ToString()
        {
            string datos = "";
            datos = "Su Frecuencia de Riego es de: " + Cantidad + " " + UnidadDeTiempo + "\n";            
            datos += "Se debe mantener a: " + Temperatura + "°C de Temp" + "\n";
            return datos;
        }
    }
}
