using System;
using System.Collections.Generic;
using System.Text;
using Repositorios;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUsos
{
    public class ManejadorCompras : IManejadorCompras
    {
        public IRepositorioCompra _repoCompra { get; set; }
        public IRepositorio<LineaFacturacion> _repoLineaFact { get; set; }
        public IRepositorioPlanta _repoPlanta { get; set; }
        public IRepositorio<Tasas> _repoTasas { get; set; }


        public ManejadorCompras(IRepositorioCompra repoCompra, IRepositorio<LineaFacturacion> lineaFact,
                                IRepositorioPlanta repoPlanta, IRepositorio<Tasas> repoTasas)
        { 
            _repoCompra = repoCompra;
            _repoLineaFact = lineaFact;
            _repoPlanta = repoPlanta;
            _repoTasas = repoTasas;
            CargarTasas();
        }

        public bool ActualizarCompra(Compra obj)
        {
            throw new NotImplementedException();
        }

        public bool AgregarCompra(Compra com)
        {
            
            if (com.SoyValido() && com!=null) { 

                foreach(LineaFacturacion c in com.PlantaCompra )
                {               
                        c.Planta = _repoPlanta.BuscarPorId(c.PlantaId);
                        c.Compra = com;
                }
                    
                com.CalcularSubTotal();
                com.CalcularTotalFinal();  
                return _repoCompra.Agregar(com);
                
            }
            return false;
        }

        public Compra BuscarPorIdCompra(int id)
        {
            return _repoCompra.BuscarPorId(id);
        }

        public bool EliminarCompra(int id)
        {
            return _repoCompra.Eliminar(id);
        }

        public IEnumerable<Compra> EncontrarTodasCompras()
        {
            return _repoCompra.EncontrarTodas();
        }

        public IEnumerable<Compra> BuscarPorTipoPlanta(int idTipoPlanta)
        {
            return _repoCompra.BuscarPorTipoPlanta(idTipoPlanta);
        }

        public void CargarTasas()
        {
            Tasas tasaIva = _repoTasas.BuscarPorId(1);
            Tasas tasaArancelaria = _repoTasas.BuscarPorId(2);
            Tasas tasaImportacion = _repoTasas.BuscarPorId(3);

            Importacion.TasaArancelaria = tasaArancelaria.Porcentaje;
            Importacion.ImpuestoImportacion = tasaImportacion.Porcentaje;
            Plaza.TasaIva = tasaIva.Porcentaje;    
        }

        public bool PreCargarCompras()
        {
            LineaFacturacion linea1 = new LineaFacturacion() { Cantidad = 2, PlantaId = 1 };
            LineaFacturacion linea2 = new LineaFacturacion() { Cantidad = 3, PlantaId = 2 };
            LineaFacturacion linea3 = new LineaFacturacion() { Cantidad = 1, PlantaId = 3 };
            LineaFacturacion linea4 = new LineaFacturacion() { Cantidad = 4, PlantaId = 5 };
            LineaFacturacion linea5 = new LineaFacturacion() { Cantidad = 3, PlantaId = 7 };
            LineaFacturacion linea6 = new LineaFacturacion() { Cantidad = 2, PlantaId = 8 };
            LineaFacturacion linea7 = new LineaFacturacion() { Cantidad = 3, PlantaId = 9 };
            LineaFacturacion linea8 = new LineaFacturacion() { Cantidad = 2, PlantaId = 10};
            LineaFacturacion linea9 = new LineaFacturacion() { Cantidad = 4, PlantaId = 6 };
            LineaFacturacion linea10 = new LineaFacturacion(){ Cantidad=  1, PlantaId = 4 };

            List<LineaFacturacion> listaF1 = new List<LineaFacturacion>();
            listaF1.Add(linea1); listaF1.Add(linea2);
            List<LineaFacturacion> listaF2 = new List<LineaFacturacion>();
            listaF2.Add(linea3); listaF2.Add(linea4);
            List<LineaFacturacion> listaF3 = new List<LineaFacturacion>();
            listaF3.Add(linea5); listaF3.Add(linea6);
            List<LineaFacturacion> listaF4 = new List<LineaFacturacion>();
            listaF4.Add(linea7); listaF4.Add(linea8);
            List<LineaFacturacion> listaF5 = new List<LineaFacturacion>();
            listaF5.Add(linea9); listaF5.Add(linea10);

            Plaza com1 = new Plaza() { Fecha = new DateTime(), CostoFlete = 100, PlantaCompra = listaF1 };
            Plaza com2 = new Plaza() { Fecha = new DateTime(), CostoFlete = 100, PlantaCompra = listaF2 };
            Plaza com3 = new Plaza() { Fecha = new DateTime(), CostoFlete = 0, PlantaCompra = listaF3 };
            Plaza com4 = new Plaza() { Fecha = new DateTime(), CostoFlete = 0, PlantaCompra = listaF4 };
            Plaza com5 = new Plaza() { Fecha = new DateTime(), CostoFlete = 100, PlantaCompra = listaF5 };
            bool ok1=AgregarCompra(com1); bool ok2 =AgregarCompra(com2); bool ok3=AgregarCompra(com3);
            bool ok4= AgregarCompra(com4);bool ok5 = AgregarCompra(com5);

            LineaFacturacion linea11 = new LineaFacturacion() { Cantidad = 2, PlantaId = 1 };
            LineaFacturacion linea12 = new LineaFacturacion() { Cantidad = 3, PlantaId = 2 };
            LineaFacturacion linea13 = new LineaFacturacion() { Cantidad = 1, PlantaId = 3 };
            LineaFacturacion linea14 = new LineaFacturacion() { Cantidad = 4, PlantaId = 4 };
            LineaFacturacion linea15 = new LineaFacturacion() { Cantidad = 3, PlantaId = 5 };
            LineaFacturacion linea16 = new LineaFacturacion() { Cantidad = 2, PlantaId = 6 };
            LineaFacturacion linea17 = new LineaFacturacion() { Cantidad = 3, PlantaId = 7 };
            LineaFacturacion linea18 = new LineaFacturacion() { Cantidad = 2, PlantaId = 8 };
            LineaFacturacion linea19 = new LineaFacturacion() { Cantidad = 4, PlantaId = 9 };
            LineaFacturacion linea20 = new LineaFacturacion() { Cantidad = 1, PlantaId = 10};

            List<LineaFacturacion> listaF6 = new List<LineaFacturacion>();
            listaF6.Add(linea11); listaF6.Add(linea12);
            List<LineaFacturacion> listaF7 = new List<LineaFacturacion>();
            listaF7.Add(linea13); listaF7.Add(linea14);
            List<LineaFacturacion> listaF8 = new List<LineaFacturacion>();
            listaF8.Add(linea15); listaF8.Add(linea16);
            List<LineaFacturacion> listaF9 = new List<LineaFacturacion>();
            listaF9.Add(linea17); listaF9.Add(linea18);
            List<LineaFacturacion> listaF10 = new List<LineaFacturacion>();
            listaF10.Add(linea19); listaF10.Add(linea20);

            Importacion com6 = new Importacion(){Fecha=new DateTime(), PlantaCompra= listaF6 , MedidasSanitarias= "Tapaboca" ,AmericaDelSur=true};
            Importacion com7 = new Importacion(){Fecha=new DateTime(), PlantaCompra= listaF7 , MedidasSanitarias= "Tapaboca" ,AmericaDelSur=true};
            Importacion com8 = new Importacion(){Fecha=new DateTime(), PlantaCompra= listaF8 , MedidasSanitarias= "Tapaboca" ,AmericaDelSur=false};
            Importacion com9 = new Importacion(){Fecha=new DateTime(), PlantaCompra= listaF9 , MedidasSanitarias= "Tapaboca" ,AmericaDelSur=false};
            Importacion com10= new Importacion(){Fecha=new DateTime(), PlantaCompra= listaF10, MedidasSanitarias= "Tapaboca" ,AmericaDelSur=false};
            bool ok6 = AgregarCompra(com6); bool ok7 = AgregarCompra(com7); bool ok8 = AgregarCompra(com8);
            bool ok9 = AgregarCompra(com9); bool ok10 = AgregarCompra(com10);     
            
            if(ok1 && ok2 && ok3 && ok4 && ok5 && ok6 && ok7 && ok8 && ok9 && ok10)
            {
                return true;
            }
            return false;
        }

    }

}
