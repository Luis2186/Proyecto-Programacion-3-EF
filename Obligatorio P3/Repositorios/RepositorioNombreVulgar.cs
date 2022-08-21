using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioNombreVulgar : IRepositorio<NombreVulgar>
    {

        public ObligatorioContext Db { get; set; }

        public RepositorioNombreVulgar(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Agregar(NombreVulgar nomV)
        {
            bool agregado = false;

            Db.NombreVulgar.Add(nomV);
            agregado = Db.SaveChanges() >=1;
           
            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            NombreVulgar nom = Db.NombreVulgar.Find(id);
            if (nom != null)
            {
                Db.NombreVulgar.Remove(nom);
                eliminada= Db.SaveChanges()>=1;  
            }
            return eliminada;
        }

        public bool Actualizar(NombreVulgar nomV)
        {
            Db.NombreVulgar.Update(nomV);
            return Db.SaveChanges() >= 1; ;
        }

        public IEnumerable<NombreVulgar> EncontrarTodas()
        {
            return Db.NombreVulgar.ToList();
        }

        public NombreVulgar BuscarPorId(int id)
        {
            return Db.NombreVulgar.Find(id);
        }
  
    }
}
