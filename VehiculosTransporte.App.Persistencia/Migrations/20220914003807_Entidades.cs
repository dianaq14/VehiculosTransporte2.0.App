using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiculosTransporte.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenciaConduccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<int>(type: "int", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo_año = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadPasajeros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueñoId = table.Column<int>(type: "int", nullable: true),
                    MecanicoId = table.Column<int>(type: "int", nullable: true),
                    ConductorId = table.Column<int>(type: "int", nullable: true),
                    Soat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeguroContractual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeguroExtracontractual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisionTecnicoMecanica = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehiculos_personas_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_vehiculos_personas_DueñoId",
                        column: x => x.DueñoId,
                        principalTable: "personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_vehiculos_personas_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "revisones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRevision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NivelAceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidoFrenos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelRefrigerante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidoDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repuestos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorRepuestos = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revisones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_revisones_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiciosTransporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaServicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recorrido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiculoId = table.Column<int>(type: "int", nullable: true),
                    TipoServicio = table.Column<int>(type: "int", nullable: false),
                    ValorServicio = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosTransporte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciosTransporte_personas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiciosTransporte_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_revisones_VehiculoId",
                table: "revisones",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosTransporte_ClienteId",
                table: "ServiciosTransporte",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosTransporte_VehiculoId",
                table: "ServiciosTransporte",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_ConductorId",
                table: "vehiculos",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_DueñoId",
                table: "vehiculos",
                column: "DueñoId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_MecanicoId",
                table: "vehiculos",
                column: "MecanicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "revisones");

            migrationBuilder.DropTable(
                name: "ServiciosTransporte");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
