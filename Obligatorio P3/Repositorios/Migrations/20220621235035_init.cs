using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorios.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    MedidasSanitarias = table.Column<string>(nullable: true),
                    AmericaDelSur = table.Column<bool>(nullable: true),
                    CostoFlete = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iluminaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iluminaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDePlantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDePlantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FichaDeCuidados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(nullable: false),
                    UnidadDeTiempo = table.Column<string>(nullable: false),
                    Temperatura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoDeIluminacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaDeCuidados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichaDeCuidados_Iluminaciones_TipoDeIluminacionId",
                        column: x => x.TipoDeIluminacionId,
                        principalTable: "Iluminaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(nullable: true),
                    NombreCientifico = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Ambiente = table.Column<string>(nullable: false),
                    AlturaMaxima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Foto = table.Column<string>(nullable: false),
                    FichaDeCuidadosId = table.Column<int>(nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantas_FichaDeCuidados_FichaDeCuidadosId",
                        column: x => x.FichaDeCuidadosId,
                        principalTable: "FichaDeCuidados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plantas_TipoDePlantas_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TipoDePlantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturacion",
                columns: table => new
                {
                    PlantaId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturacion", x => new { x.PlantaId, x.CompraId });
                    table.ForeignKey(
                        name: "FK_Facturacion_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturacion_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NombreVulgar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomVulgar = table.Column<string>(nullable: false),
                    PlantaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NombreVulgar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NombreVulgar_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturacion_CompraId",
                table: "Facturacion",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_FichaDeCuidados_TipoDeIluminacionId",
                table: "FichaDeCuidados",
                column: "TipoDeIluminacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Iluminaciones_Nombre",
                table: "Iluminaciones",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NombreVulgar_PlantaId",
                table: "NombreVulgar",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_FichaDeCuidadosId",
                table: "Plantas",
                column: "FichaDeCuidadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_NombreCientifico",
                table: "Plantas",
                column: "NombreCientifico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_TipoId",
                table: "Plantas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasas_Nombre",
                table: "Tasas",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDePlantas_Nombre",
                table: "TipoDePlantas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturacion");

            migrationBuilder.DropTable(
                name: "NombreVulgar");

            migrationBuilder.DropTable(
                name: "Tasas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Plantas");

            migrationBuilder.DropTable(
                name: "FichaDeCuidados");

            migrationBuilder.DropTable(
                name: "TipoDePlantas");

            migrationBuilder.DropTable(
                name: "Iluminaciones");
        }
    }
}
