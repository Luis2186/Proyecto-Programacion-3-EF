using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioFichaDeCiudadoEF : IRepositorio<FichaDeCuidado>
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioFichaDeCiudadoEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Agregar(FichaDeCuidado unaF)
        {
            bool agregado = false;

            Db.FichaDeCuidados.Add(unaF);
            int altas = Db.SaveChanges();
            agregado = altas != 0;

            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            FichaDeCuidado unaF = Db.FichaDeCuidados.Find(id);
            if (unaF != null)
            {
                Db.FichaDeCuidados.Remove(unaF);
                eliminada= Db.SaveChanges() >=1;  
            }
            return eliminada;
        }

        public bool Actualizar(FichaDeCuidado obj)
        {
            Db.FichaDeCuidados.Update(obj);
            return Db.SaveChanges() >= 1;
        }

        public IEnumerable<FichaDeCuidado> EncontrarTodas()
        {
            return Db.FichaDeCuidados.Include(fc => fc.TipoDeIluminacion)
                                     .ThenInclude(fc=> fc.Nombre)
                                     .ToList();
        }

        public FichaDeCuidado BuscarPorId(int id)
        {
            return Db.FichaDeCuidados.Include(fc => fc.TipoDeIluminacion)                                 
                                     .Where(fc => fc.Id == id).SingleOrDefault();
        }
             

    }
}
