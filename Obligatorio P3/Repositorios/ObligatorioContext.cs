using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Dominio.EntidadesNegocio;
using System.Linq;
namespace Repositorios
{
    public class ObligatorioContext : DbContext
    {
        public DbSet<Planta> Plantas { get; set; }
        public DbSet<TipoDePlanta> TipoDePlantas { get; set; }
        public DbSet<FichaDeCuidado> FichaDeCuidados { get; set; }
        public DbSet<NombreVulgar> NombreVulgar { get; set; }
        public DbSet<TipoDeIluminacion> Iluminaciones { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Plaza> Plazas { get; set; }
        public DbSet<Importacion> Importaciones { get; set; }
        public DbSet<LineaFacturacion> Facturacion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tasas> Tasas { get; set; }


        public ObligatorioContext() { }
        public ObligatorioContext(DbContextOptions<ObligatorioContext> options): base (options)
        {           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FichaDeCuidado>().Property(fdc => fdc.Temperatura).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<LineaFacturacion>().Property(lf => lf.PrecioUnitario).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Planta>().Property(pl => pl.AlturaMaxima).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Planta>().Property(pl => pl.Precio).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Plaza>().Property(comPla => comPla.CostoFlete).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Tasas>().Property(tasa => tasa.Porcentaje).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Compra>().Property(com => com.Total).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Compra>().Property(com => com.SubTotal).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Usuario>().HasIndex(user => user.Email).IsUnique();
            modelBuilder.Entity<Planta>().HasIndex(pl => pl.NombreCientifico).IsUnique();
            modelBuilder.Entity<TipoDePlanta>().HasIndex(tipoPl => tipoPl.Nombre).IsUnique();
            modelBuilder.Entity<TipoDeIluminacion>().HasIndex(tipoIlu => tipoIlu.Nombre).IsUnique();
            modelBuilder.Entity<Tasas>().HasIndex(tasa => tasa.Nombre).IsUnique();


            modelBuilder.Entity<Planta>().HasMany(pl => pl.PlantaCompra).WithOne(comP => comP.Planta);
            modelBuilder.Entity<Compra>().HasMany(com => com.PlantaCompra).WithOne(comP => comP.Compra);

            modelBuilder.Entity<LineaFacturacion>().HasKey(lF => new { lF.PlantaId, lF.CompraId });
            modelBuilder.Entity<LineaFacturacion>().Property(lF => lF.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }

    }
}
