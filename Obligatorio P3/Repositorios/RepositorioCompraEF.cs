using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioCompraEF : IRepositorioCompra
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioCompraEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Agregar(Compra com)
        {
            bool agregado = false;

            if (com.SoyValido() && com != null)
            {
                Db.Compras.Add(com);
                agregado = Db.SaveChanges()>=1;       
            }
            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            Compra com = Db.Compras.Find(id);
            if (com != null)
            {
                Db.Compras.Remove(com);
                eliminada= Db.SaveChanges() >=1;                
            }
            return eliminada;
        }

        public bool Actualizar(Compra com)
        {
            if (com.SoyValido() && com != null)
            {
                Db.Compras.Update(com);
            }
            return Db.SaveChanges() >= 1;
        }

        public IEnumerable<Compra> EncontrarTodas()
        {
            return Db.Compras.Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.FichaDeCuidados)
                             .ThenInclude(com => com.TipoDeIluminacion)
                             .Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.Tipo)
                             .Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.NombresVulgares)
                             .ToList();
        }

        public Compra BuscarPorId(int id)
        {
            return Db.Compras.Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.FichaDeCuidados)
                             .ThenInclude(com => com.TipoDeIluminacion)
                             .Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.Tipo)
                             .Include(com => com.PlantaCompra)
                             .ThenInclude(com => com.Planta)
                             .ThenInclude(com => com.NombresVulgares)
                             .Where(com => com.Id == id).SingleOrDefault();          
        }

        public IEnumerable<Compra> BuscarPorTipoPlanta(int idTipoPlanta)
        {
            return Db.Compras.Where(com => com.PlantaCompra.Any(pc => pc.Planta.Tipo.Id == idTipoPlanta))
                                 .Include(com => com.PlantaCompra)
                                 .ThenInclude(com => com.Planta)
                                 .ThenInclude(com => com.FichaDeCuidados)
                                 .ThenInclude(com => com.TipoDeIluminacion)
                                 .Include(com => com.PlantaCompra)
                                 .ThenInclude(com => com.Planta)
                                 .ThenInclude(com => com.Tipo)
                                 .Include(com => com.PlantaCompra)
                                 .ThenInclude(com => com.Planta)
                                 .ThenInclude(com => com.NombresVulgares)
                                 .ToList(); 
        }

    }
}
