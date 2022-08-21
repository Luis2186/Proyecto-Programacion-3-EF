using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasosUsos;
using Dominio.EntidadesNegocio;
using WebObligatoriop3.Models;



namespace WebObligatoriop3.Controllers
{
    public class LoginController : Controller
    {
        public IManejadorUsuario User { get; set; }

        public LoginController(IManejadorUsuario usuario, IManejadorCompras com) 
        {
            User = usuario;
        }

        public IActionResult Login()
        {
            ViewModelLogin log = new ViewModelLogin();
            return View();
        }
        [HttpPost]
        public IActionResult Login(ViewModelLogin log)
        {
            Usuario userBus = User.IniciarSesion(log.Email,log.Contraseña);            

            if (userBus != null)
            {
                HttpContext.Session.SetInt32("User_Id", userBus.Id);
                HttpContext.Session.SetString("UsuarioAutorizado","Si");
                Planta.ValidacionDesde = log.ValiPlantaDesde;
                Planta.ValidacionHasta = log.ValiPlantaHasta;
                TipoDePlanta.ValidacionDesde = log.ValiTipoDePlantaDesde;
                TipoDePlanta.ValidacionHasta = log.ValiTipoDePlantaHasta;

            }
            else
            {      
                ViewBag.Error = "Las credenciales son incorrectas o se encuentran vacias.";
                ViewBag.Error1 = "¡Ingrese los datos correctamente y vuelva a intentarlo!";
            }

            if (HttpContext.Session.GetString("UsuarioAutorizado") == "Si")
            {
                return RedirectToAction("Bienvenida", "Usuario");
            }
            else
            {
                return View();
            }
        }
        public IActionResult LogOut()
        {    
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }

        public IActionResult CargaDeUsuarios()
        {
            Usuario usuario1 = new Usuario()
            {
                Nombre = "Luis",
                Apellido = "Lopez",
                Email = "lucho@hotmail.com",
                Contraseña = "Lucho123"
            };
            Usuario usuario2 = new Usuario()
            {
                Nombre = "Karelina",
                Apellido = "Fabra",
                Email = "kare@gmail.com",
                Contraseña = "Kare123"
            };
            Usuario usuario3 = new Usuario()
            {
                Nombre = "Federico",
                Apellido = "Stole",
                Email = "fede@hotmail.com",
                Contraseña = "Fede123"
            };

            bool agregado= User.AgregarNuevoUsuario(usuario1);
            bool agregado1= User.AgregarNuevoUsuario(usuario2);
            bool agregado2= User.AgregarNuevoUsuario(usuario3);

            if(agregado && agregado1 && agregado2)
            {
                TempData["cargaOk"] = "¡Los usuarios se cargaron exitosamente!";
            } else
            {
                TempData["cargaError"] ="¡Los usuarios ya se encuentran cargados en el sistema!";
            }
                return RedirectToAction("Login");   
        }


    }
}
