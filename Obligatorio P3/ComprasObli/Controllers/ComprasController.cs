using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using CasosUsos;
using ComprasDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComprasObli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        public IManejadorCompras _manCom { get; set; }

        public ComprasController(IManejadorCompras manC)
        {
            _manCom = manC;
        }

        // GET: api/<ComprasController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_manCom.EncontrarTodasCompras());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // GET api/Compras/5
        [HttpGet("{id}")]
        [Route("{id}", Name ="Obtener")]
        public IActionResult FindById(int id){

            try
            {
                if (id == 0) return BadRequest();

                Compra comprasBus = _manCom.BuscarPorIdCompra(id);

                if (comprasBus == null) return NotFound();

                return Ok(comprasBus);
            }
            catch (Exception ex)
            {
               return StatusCode(500);
            }

        }

        // GET api/Compras/tipodeplanta/
        [HttpGet("tipodeplanta/{idTipoDePlanta}")]
        public IActionResult Get(int idTipoDePlanta)
        {
            try
            { 
                if (idTipoDePlanta == 0) return BadRequest();

                IEnumerable<Compra> comprasBus = _manCom.BuscarPorTipoPlanta(idTipoDePlanta);

                if (!comprasBus.Any()) return NotFound();
                IEnumerable<CompraDTO> dtos = comprasBus.Select(comp => new CompraDTO()
                {
                    IdCompra = comp.Id,
                    Fecha = comp.Fecha,
                    LineaFact = comp.PlantaCompra.Select(lf => new LineaFactDTO()
                    {
                        Id = lf.Id,
                        PrecioUnitario = lf.PrecioUnitario,
                        CantidadUnidadesCompradas = lf.Cantidad,
                        Planta = new PlantaDTO()
                        {
                            Id = lf.Planta.Id,
                            Tipo = new TipoPlantaDTO()
                            {
                                Nombre = lf.Planta.Tipo.Nombre,
                                Descripcion = lf.Planta.Tipo.Descripcion
                            },
                            NombreCientifico = lf.Planta.NombreCientifico,
                            NombresVulgares = string.Join(" -", lf.Planta.NombresVulgares.Select(nombre => nombre.NomVulgar)),
                            Descripcion = lf.Planta.Descripcion,
                            Ambiente = lf.Planta.Ambiente,
                            AlturaMaxima = lf.Planta.AlturaMaxima,
                            Foto = lf.Planta.Foto,
                            FichaDeCuidados = new FichaDTO()
                            {
                                Cantidad = lf.Planta.FichaDeCuidados.Cantidad,
                                UnidadDeTiempo = lf.Planta.FichaDeCuidados.UnidadDeTiempo,
                                Temperatura = lf.Planta.FichaDeCuidados.Temperatura,
                                TipoDeIluminacion = lf.Planta.FichaDeCuidados.TipoDeIluminacion.Nombre
                            },
                            Precio = lf.Planta.Precio
                        }
                    }),
                    Total = comp.Total,
                    MontoImpuestos = comp.Total - comp.SubTotal,
                    TipoDeCompra = comp.DefinirCompra(),
                    TasaIva = comp is Plaza ? Plaza.TasaIva : 0,
                    CostoFlete = comp is Plaza ? (comp as Plaza).CostoFlete : 0,
                    ImpuestoImportacion = comp is Importacion ? Importacion.ImpuestoImportacion : 0,
                    PerteneceAmericaDelSur = comp is Importacion ? (comp as Importacion).AmericaDelSur : false,
                    TasaArancelaria = comp is Importacion ? Importacion.TasaArancelaria : 0,
                    MedidasSanitarias = comp is Importacion ? (comp as Importacion).MedidasSanitarias : null,
                });
                return Ok(dtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }  
        }

        // POST api/Compras/Plaza
        [HttpPost]
        [Route("Plaza")]
        public ActionResult<Compra> Post([FromBody] Plaza compraP)
        { 
            try {

                if (compraP.PlantaCompra == null) { return BadRequest("¡La compra no existe!");}
            
                bool comAgregada = _manCom.AgregarCompra(compraP);

                if (comAgregada) {
                    return CreatedAtRoute("Obtener", new { id = compraP.Id }, compraP);
                }
            
                return Conflict(compraP);
            }catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("Importacion")]
        public ActionResult<Compra> Post([FromBody] Importacion compraI)
        {
            try
            {
                if (compraI.PlantaCompra == null) { return BadRequest("¡La compra no existe!"); }

                bool comAgregada = _manCom.AgregarCompra(compraI);

                if (comAgregada) {
                    return CreatedAtRoute("Obtener", new { id = compraI.Id }, compraI);
                }

                return Conflict(compraI);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // PUT api/<ComprasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Compra com)
        {
            try
            {
                if (com.Id != 0 && id == com.Id)
                {
                    bool act = _manCom.ActualizarCompra(com);
                    if (!act) return Conflict();
                    return Ok(com);
                }
                else
                {
                    return BadRequest();
                }   
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<ComprasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == 0) return BadRequest();

                Compra comBus = _manCom.BuscarPorIdCompra(id);
                if (comBus == null) return NotFound();

                bool eliminado = _manCom.EliminarCompra(id);
                if (!eliminado) return Conflict();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500);               
            }

        }
    }
}
