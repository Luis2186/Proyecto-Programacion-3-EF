using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasosUsos;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using WebObligatoriop3.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using ComprasDTO;
using Newtonsoft.Json;
using System.Net.Http;

namespace WebObligatoriop3.Controllers
{
    public class CompraController : Controller
    {
        // GET: CompraController

        public IManejadorCompras mCompras { get; set; }
        public IRepositorioTipoDePlanta _repoTdp { get; set; }
        public CompraController(IManejadorCompras compra, IRepositorioTipoDePlanta repoTdp)
        {
            mCompras = compra;
            _repoTdp = repoTdp;
        }

        public ActionResult Index()
        {

            return View();
        }

        // GET: CompraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompraController/Create
        public ActionResult ListaFiltrada()
        {
            if (HttpContext.Session.GetString("UsuarioAutorizado") == "Si")
            {
                ViewBag.ListaTipoP = _repoTdp.EncontrarTodas();
                IEnumerable<CompraDTO> dtoC = new List<CompraDTO>();

                return View(dtoC);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
           
        }

        // POST: CompraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ListaFiltrada(int idTipoDePlanta)
        {
            if (HttpContext.Session.GetString("UsuarioAutorizado") == "Si")
            {
                try
                {          
                    ViewBag.ListaTipoP = _repoTdp.EncontrarTodas();
                    IEnumerable<CompraDTO> dtoC = new List<CompraDTO>();
                    HttpClient cliente = new HttpClient();
                    Task<HttpResponseMessage> respuesta = cliente.GetAsync("http://localhost:49809/api/Compras/tipodeplanta/" + idTipoDePlanta);
                    respuesta.Wait();

                    if (respuesta.Result.IsSuccessStatusCode)
                    {
                        Task<string> contenido = respuesta.Result.Content.ReadAsStringAsync();
                        contenido.Wait();

                        string json = contenido.Result;
                        dtoC = JsonConvert.DeserializeObject<IEnumerable<CompraDTO>>(json);
                    }
                    else
                    {
                        ViewBag.Error = "No se encuentra el tipo de planta seleccionado";
                    }

                    return View(dtoC);
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: CompraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompraController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompraController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult PreCargarCompras(int id)
        {
            if (HttpContext.Session.GetString("UsuarioAutorizado") == "Si")
            {
                try
                {
                    bool cargaOk = mCompras.PreCargarCompras();
                    if (cargaOk)
                    {
                        TempData["cargaOk"] = "Se cargo Correctamente las compras";
                        return RedirectToAction("ListaFiltrada");
                    }
                    else
                    {
                        TempData["cargaError"] = "No se cargaron correctamente las compras";
                        return RedirectToAction("ListaFiltrada");
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }


    }
}
