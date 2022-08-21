using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioLineaFacturacionEF : IRepositorio<LineaFacturacion>
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioLineaFacturacionEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Agregar(LineaFacturacion lF)
        {
            bool agregado = false;

            Db.Facturacion.Add(lF);
            agregado = Db.SaveChanges()>=1;

            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            LineaFacturacion lF = Db.Facturacion.Find(id);
            if (lF != null)
            {
                Db.Facturacion.Remove(lF);
                eliminada= Db.SaveChanges() >=1;
            }
            return eliminada;
        }

        public bool Actualizar(LineaFacturacion obj)
        {
            Db.Facturacion.Update(obj);       
            return Db.SaveChanges() >= 1;
        }

        public IEnumerable<LineaFacturacion> EncontrarTodas()
        {
            return Db.Facturacion.Include(lf => lf.Planta)
                                 .ThenInclude(lf => lf.Tipo)
                                 .Include(lf => lf.Planta)
                                 .ThenInclude(lf => lf.NombresVulgares)
                                 .Include(lf => lf.Planta)
                                 .ThenInclude(lf => lf.FichaDeCuidados)
                                 .ThenInclude(lf => lf.TipoDeIluminacion)
                                 .Include (lf => lf.Compra)
                                 .ToList();
        }

        public LineaFacturacion BuscarPorId(int id)
        {
            return Db.Facturacion.Include(lf => lf.Planta)
                .ThenInclude(lf => lf.Tipo)
                                 .Include(lf => lf.Planta)
                                 .ThenInclude(lf => lf.NombresVulgares)
                                 .Include(lf => lf.Planta)
                                 .ThenInclude(lf => lf.FichaDeCuidados)
                                 .ThenInclude(lf => lf.TipoDeIluminacion)
                                 .Include(lf => lf.Compra)
                                 .Where(lf => lf.Id == id).SingleOrDefault();
        }

    }
}
