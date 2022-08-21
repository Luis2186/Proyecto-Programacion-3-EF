using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioTipoDeIluminacionEF : IRepositorio<TipoDeIluminacion>
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioTipoDeIluminacionEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Agregar(TipoDeIluminacion ilu)
        {
            bool agregado = false;

            Db.Iluminaciones.Add(ilu);
            int altas = Db.SaveChanges();
            agregado = altas != 0;

            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            TipoDeIluminacion ilu = Db.Iluminaciones.Find(id);
            if (ilu != null)
            {
                Db.Iluminaciones.Remove(ilu);
                Db.SaveChanges();
                eliminada = true;
            }
            return eliminada;
        }

        public bool Actualizar(TipoDeIluminacion obj)
        {
            Db.Iluminaciones.Update(obj);
            return Db.SaveChanges() >= 1;
        }

        public IEnumerable<TipoDeIluminacion> EncontrarTodas()
        {
            return Db.Iluminaciones.ToList();
        }

        public TipoDeIluminacion BuscarPorId(int id)
        {
            return Db.Iluminaciones.Find(id);
        }
    }
}
