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
                name: "Personas",
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
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<int>(type: "int", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo_año = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadPasajeros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuenioId = table.Column<int>(type: "int", nullable: true),
                    MecanicoId = table.Column<int>(type: "int", nullable: true),
                    ConductorId = table.Column<int>(type: "int", nullable: true),
                    Soat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeguroContractual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeguroExtracontractual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisionTecnicoMecanica = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_DuenioId",
                        column: x => x.DuenioId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
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
                    table.PrimaryKey("PK_Revisiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Revisiones_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
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
                        name: "FK_ServiciosTransporte_Personas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiciosTransporte_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_VehiculoId",
                table: "Revisiones",
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
                name: "IX_Vehiculos_ConductorId",
                table: "Vehiculos",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_DuenioId",
                table: "Vehiculos",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MecanicoId",
                table: "Vehiculos",
                column: "MecanicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "ServiciosTransporte");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
