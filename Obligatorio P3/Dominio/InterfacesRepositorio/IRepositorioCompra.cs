using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.InterfacesRepositorio
{
    public interface IRepositorioCompra : IRepositorio<Compra>
    {
        public IEnumerable<Compra> BuscarPorTipoPlanta(int id);

    }
}
