using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasosUsos;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;
using Repositorios;
using Microsoft.EntityFrameworkCore;

namespace WebObligatoriop3
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.AddSession(options => {

                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
                  
            services.AddScoped<IManejadorUsuario, ManejadorUsuario>();
            services.AddScoped<IManejadorPlantas, ManejadorPlantas>();
            services.AddScoped<IManejadorCompras, ManejadorCompras>();
            
            services.AddScoped<IRepositorioUsuario, RepositorioUsuarioEF>();
            services.AddScoped<IRepositorioTipoDePlanta, RepositorioTipoDePlantaEF>();
            services.AddScoped<IRepositorioPlanta, RepositorioPlantaEF>();
            services.AddScoped<IRepositorioCompra, RepositorioCompraEF>();
            services.AddScoped<IRepositorio<TipoDeIluminacion>, RepositorioTipoDeIluminacionEF>();
            services.AddScoped<IRepositorio<FichaDeCuidado>, RepositorioFichaDeCiudadoEF>();
            services.AddScoped<IRepositorio<Tasas>, RepositorioTasasEF>();  
            services.AddScoped<IRepositorio<LineaFacturacion>, RepositorioLineaFacturacionEF>();
            services.AddScoped<IRepositorio<NombreVulgar>, RepositorioNombreVulgar>();

            services.AddDbContext<ObligatorioContext>(option => option.UseSqlServer(Configuration.GetConnectionString("ConexionSQLEF")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=login}/{id?}");
            });
        }
    }
}
