using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;
using CasosUsos;
using Repositorios;

namespace ComprasObli
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Ignora las referencias circulares, evitando un loop infinito 
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddDbContext<ObligatorioContext>(option => 
            option.UseSqlServer(Configuration.GetConnectionString("ConexionSQLEF")));

            services.AddScoped<IManejadorCompras, ManejadorCompras>();

            services.AddScoped<IRepositorioCompra, RepositorioCompraEF>();
            services.AddScoped<IRepositorio<LineaFacturacion>, RepositorioLineaFacturacionEF>();
            services.AddScoped<IRepositorioPlanta, RepositorioPlantaEF>();
            services.AddScoped<IRepositorio<Tasas>, RepositorioTasasEF>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
