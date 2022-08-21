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
    public class RepositorioTipoDePlantaEF : IRepositorioTipoDePlanta
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioTipoDePlantaEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }
         public bool Agregar(TipoDePlanta unaF)
        {
            bool agregado = false;

            Db.TipoDePlantas.Add(unaF);
            int altas = Db.SaveChanges();
            agregado = altas != 0;

            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            TipoDePlanta tDP = Db.TipoDePlantas.Find(id);
            if (tDP != null)
            {
                Db.TipoDePlantas.Remove(tDP);
                Db.SaveChanges();
                eliminada = true;
            }
            return eliminada;
        }

        public bool Actualizar(TipoDePlanta obj)
        {
            Db.TipoDePlantas.Update(obj);
            return Db.SaveChanges() >= 1; ;
        }

        public IEnumerable<TipoDePlanta> EncontrarTodas()
        {
            return Db.TipoDePlantas.ToList();
        }

        public TipoDePlanta BuscarPorId(int id)
        {
            return Db.TipoDePlantas.Find(id);
        }

        public TipoDePlanta BuscarPorNombre(string nombre)
        {
            return Db.TipoDePlantas.Where(tDP => tDP.Nombre == nombre).SingleOrDefault();
        }
        public bool EliminarPorNombre(string nombre)
        {
            bool eliminada = false;
            TipoDePlanta tDP = BuscarPorNombre(nombre);

            if(tDP != null) {
                Db.TipoDePlantas.Remove(tDP);
                Db.SaveChanges();
                eliminada = true;
            }
            return eliminada;
        }

    }
}
