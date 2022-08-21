using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Repositorios;

namespace CasosUsos
{
    public interface IManejadorCompras
    {
        public bool ActualizarCompra(Compra obj);
        public bool AgregarCompra(Compra com);
        public Compra BuscarPorIdCompra(int id);
        public bool EliminarCompra(int id);
        public IEnumerable<Compra> EncontrarTodasCompras();
        public IEnumerable<Compra> BuscarPorTipoPlanta(int idTipoPlanta);
        public void CargarTasas();
        public bool PreCargarCompras();
    }
}
