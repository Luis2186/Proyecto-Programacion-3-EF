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
    public class RepositorioTasasEF : IRepositorio<Tasas>
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioTasasEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Actualizar(Tasas tasa)
        {
            Db.Tasas.Update(tasa);
            return Db.SaveChanges() >= 1;
        }

        public bool Agregar(Tasas tasa)
        {
            bool agregado = false;

            if (tasa != null)
            {    
                Db.Tasas.Add(tasa);
                agregado = Db.SaveChanges() >=1;    
            }
            return agregado;
        }

        public Tasas BuscarPorId(int id)
        {
            return Db.Tasas.Find(id);
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            Tasas tasa = Db.Tasas.Find(id);
            if (tasa != null)
            {
                Db.Tasas.Remove(tasa);
                eliminada=Db.SaveChanges()>=1;
            }
            return eliminada;
        }

        public IEnumerable<Tasas> EncontrarTodas()
        {
            return Db.Tasas.ToList();
        }
    }
}
