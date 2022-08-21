using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioPlantaEF : IRepositorioPlanta
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioPlantaEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }

        public bool Actualizar(Planta unaP)
        {
            Db.Plantas.Update(unaP);     
            return Db.SaveChanges() >= 1;
        }
        public bool Agregar(Planta unaP)
        {
            bool agregado = false;

            Db.Plantas.Add(unaP);
            agregado = Db.SaveChanges() >=1;

            return agregado;
        }
        public bool Eliminar(int id)
        {
            bool eliminada = false;
            Planta unaP = Db.Plantas.Find(id);
            if (unaP != null)
            {
                Db.Plantas.Remove(unaP);
                eliminada = Db.SaveChanges() >=1;
            }
            return eliminada;
        }
        public Planta BuscarPorId(int id)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .ThenInclude(pl => pl.TipoDeIluminacion)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(pl => pl.Id == id).SingleOrDefault();
        }
        public IEnumerable<Planta> EncontrarTodas()
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .ThenInclude(pl => pl.TipoDeIluminacion)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .ToList();
        }

        public IEnumerable<Planta> BuscarPorTextoEnNombre(string nombreBuscado)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.NombreCientifico.Contains(nombreBuscado)).ToList();
        }

        public IEnumerable<Planta> BuscarPorAmbiente(string tipoDeAmbiente)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.Ambiente == tipoDeAmbiente).ToList();
        }
        public IEnumerable<Planta> BuscarPorTipo(int id)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.Tipo.Id == id).ToList();
        }
        public IEnumerable<Planta> PlantasConMismaAlturaOMas(int AlturaLimite)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.AlturaMaxima >= AlturaLimite).ToList();
        }
        public IEnumerable<Planta> PlantasMasBajas(int AlturaLimite)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.AlturaMaxima < AlturaLimite).ToList();
        }
        public Planta BuscarNombreCientifico(string nombreCientifico)
        {
            return Db.Plantas.Include(pl => pl.FichaDeCuidados)
                             .Include(pl => pl.Tipo)
                             .Include(pl => pl.NombresVulgares)
                             .Where(p => p.NombreCientifico == nombreCientifico).SingleOrDefault();
        }

        #region SQLReader
        private Planta CrearPlanta(SqlDataReader reader)
        {

            Planta planta = new Planta();

            planta.Id = reader.GetInt32(0);        
            planta.NombreCientifico = reader.GetString(2);
            planta.Descripcion = reader.GetString(3);
            planta.Ambiente = reader.GetString(4);
            planta.AlturaMaxima = reader.GetInt32(5);
            planta.Foto= reader.GetString(6);
            planta.Precio = reader.GetDecimal(8);

            return planta;
        }
        private TipoDePlanta CrearTipoDePlanta(SqlDataReader reader)
        {
            TipoDePlanta tPlanta = new TipoDePlanta();
            tPlanta.Id = reader.GetInt32(1);
            tPlanta.Nombre = reader.GetString(14);
            tPlanta.Descripcion = reader.GetString(15);

            return tPlanta;
        }
    
        private FichaDeCuidado CrearFichaDeCuidado(SqlDataReader reader)
        {
            FichaDeCuidado fC = new FichaDeCuidado();
            fC.Id = reader.GetInt32(7);
            fC.Cantidad = reader.GetInt32(9);
            fC.UnidadDeTiempo = reader.GetString(10);
            fC.Temperatura = reader.GetDecimal(11);
            return fC;
        }
        private TipoDeIluminacion CrearTipoDeIluminacion(SqlDataReader reader)
        {
            TipoDeIluminacion tI = new TipoDeIluminacion();
            tI.Id = reader.GetInt32(12);
            tI.Nombre = reader.GetString(13);

            return tI;
        }
        public List<string> BuscarTodosNombresVulgares(int idPlanta) 
        {
            List<string> nombreV = new List<string>();

            SqlConnection con = Conexion.ObtenerConexion();

            string sql = "SELECT * FROM ListaNVulgares WHERE Planta_Id=" + idPlanta;
            SqlCommand com = new SqlCommand(sql, con);

            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(2);                   
                    nombreV.Add(nombre);
                }

                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return nombreV;
        }

        #endregion  
       
     

    }
}
