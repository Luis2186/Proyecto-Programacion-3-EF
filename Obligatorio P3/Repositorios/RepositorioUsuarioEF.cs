using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioUsuarioEF : IRepositorioUsuario
    {
        public ObligatorioContext Db { get; set; }

        public RepositorioUsuarioEF(ObligatorioContext contexto)
        {
            Db = contexto;
        }
        public bool Agregar(Usuario user)
        {
            bool agregado = false;
            if(Login(user.Email, user.Contraseña) == null) { 
                Db.Usuarios.Add(user);
                agregado = Db.SaveChanges()>=1;          
            }
            return agregado;
        }

        public bool Eliminar(int id)
        {
            bool eliminada = false;
            Usuario user = Db.Usuarios.Find(id);
            if (user != null)
            {
                Db.Usuarios.Remove(user);
                Db.SaveChanges();
                eliminada = true;
            }
            return eliminada;
        }

        public bool Actualizar(Usuario obj)
        {
            Db.Usuarios.Update(obj);
            return Db.SaveChanges() >= 1;
        }

        public IEnumerable<Usuario> EncontrarTodas()
        {
            return Db.Usuarios.ToList();
        }

        public Usuario BuscarPorId(int id)
        {
            return Db.Usuarios.Find(id);
        }

        public Usuario Login(string email, string contraseña)
        {
            return Db.Usuarios.Where(user => user.Email == email && user.Contraseña == contraseña).SingleOrDefault();
        }
      
    }
}
