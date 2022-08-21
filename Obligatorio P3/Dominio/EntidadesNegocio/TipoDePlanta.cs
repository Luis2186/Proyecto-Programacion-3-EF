using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio.EntidadesNegocio
{
    public class TipoDePlanta : IValidacion
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Nombre")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "No se permiten numeros, ni caracteres especiales en el Nombre")]
        public string Nombre { get; set; } 
        //[MinLength(10, ErrorMessage = "La descripcion debe tener como minimo 10 caracteres")]
        //[MaxLength(200, ErrorMessage = "La descripcion no debe sobrepasar los 200 caracteres")]
        [Required(ErrorMessage = "Debe ingresar la descripcion")]
        public string Descripcion { get; set; }
        public static int ValidacionDesde { get; set; }
        public static int ValidacionHasta { get; set; }

        public TipoDePlanta() { }

        public bool SoyValido()
        {
            bool valido = false;   

            if (Nombre.Trim()!= "" && ValidarSoloLetrasConASCI(Nombre) && Descripcion.Length >= ValidacionDesde &&
                Descripcion.Length <= ValidacionHasta)
            {
                valido = true;
            }
            return valido;
        }
        private bool ValidarSoloLetrasConASCI(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                //A=65 Z=90 and a=97 z=122
                if ((int)texto[i] < 32 || (int)texto[i] > 32 && (int)texto[i] < 65 || ((int)texto[i] > 90
                    && (int)texto[i] < 97) || (int)texto[i] > 122)
                    return false;
            }
            return true;
        }
        public override string ToString()
        {
            return Nombre;
        }
      
    }
}
