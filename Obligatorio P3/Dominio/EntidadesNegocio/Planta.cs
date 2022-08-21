using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
    public class Planta : IValidacion
    {
        public int Id { get; set; }
        public TipoDePlanta Tipo { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Nombre Cientifico")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "No se permiten numeros, ni caracteres especiales en el Nombre Cientifico")]
        public string NombreCientifico { get; set; }
        [Required(ErrorMessage = "Debe ingresar al menos 1 Nombre Vulgar")]
        public List<NombreVulgar> NombresVulgares { get; set; }
        //[MinLength(10, ErrorMessage = "La descripcion debe tener como minimo 10 caracteres")]
        //[MaxLength(500, ErrorMessage = "La descripcion no debe sobrepasar los 500 caracteres")]
        [Required(ErrorMessage = "Debe ingresar la descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Seleccione el tipo de Ambiente")]
        public string Ambiente { get; set; }
        [Required(ErrorMessage = "Debe ingresar la Altura")]
        public decimal AlturaMaxima { get; set; }
        [Required(ErrorMessage = "Debe cargar la foto correspondiente")]
        public string Foto { get; set; }
        public FichaDeCuidado FichaDeCuidados { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Precio de la planta")]
        public decimal Precio { get; set; }    
        public List<LineaFacturacion> PlantaCompra { get; set; }
        public static int ValidacionDesde { get; set; }
        public static int ValidacionHasta { get; set; }




        public Planta() { }

        public bool SoyValido()
        {
            bool valido = false;
            if (NombreCientifico.Trim() != "" && NombresVulgares.Count > 0 && Ambiente != "" && Foto != "" 
                &&  ValidarAmbiente() && ValidarExtensionFoto(Foto) && Descripcion.Length >= ValidacionDesde
                && Descripcion.Length <= ValidacionHasta)
            {
                valido = true;
            }
            return valido;
        }

        private bool ValidarAmbiente()
        {
            bool valido = false;
            if (Ambiente.Trim() == "Interior" || Ambiente.Trim() == "Exterior" || Ambiente.Trim() == "Mixta")
            {
                valido = true;

            }
            return valido;
        }
        public string FormatoFoto()
        {
            string codigo = "001";
            if (NombreCientifico != "" && NombreCientifico!= null)
            {
                Foto = NombreCientifico.Replace(" ", "_").Trim() + "_" + codigo;
            }
            else
            {
                Foto = "";
            }
            return Foto;
        }
        public string TomarExtension(string archivo)
        {
            string extension = "";
            for (int i= archivo.Length - 4; i < archivo.Length; i++)
            {
                extension += archivo[i];
            }
            return extension;
        }
        private bool ValidarExtensionFoto(string archivo)
        {
            string extension = "";
            bool valido = false;
            for (int i = archivo.Length - 4; i < archivo.Length; i++)
            {
                extension += archivo[i];
            }
            if (extension == ".png" || extension == ".jpg")
            {
                valido = true;
            }
            return valido;
        }  
        public void AgregarNombreVulgar(NombreVulgar nombre)
        {
            if (NombresVulgares == null)
            {
                NombresVulgares = new List<NombreVulgar>();
            }
            NombresVulgares.Add(nombre);            
        }



    }
}
