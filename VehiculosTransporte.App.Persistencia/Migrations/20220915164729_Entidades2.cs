using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiculosTransporte.App.Persistencia.Migrations
{
    public partial class Entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revisones_vehiculos_VehiculoId",
                table: "revisones");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosTransporte_personas_ClienteId",
                table: "ServiciosTransporte");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosTransporte_vehiculos_VehiculoId",
                table: "ServiciosTransporte");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_personas_ConductorId",
                table: "vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_personas_DueñoId",
                table: "vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_personas_MecanicoId",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_revisones",
                table: "revisones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.RenameTable(
                name: "vehiculos",
                newName: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "revisones",
                newName: "Revisones");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "Personas");

            migrationBuilder.RenameColumn(
                name: "DueñoId",
                table: "Vehiculos",
                newName: "DuenioId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_MecanicoId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_MecanicoId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_ConductorId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ConductorId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_DueñoId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_DuenioId");

            migrationBuilder.RenameIndex(
                name: "IX_revisones_VehiculoId",
                table: "Revisones",
                newName: "IX_Revisones_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Revisones",
                table: "Revisones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Revisones_Vehiculos_VehiculoId",
                table: "Revisones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosTransporte_Personas_ClienteId",
                table: "ServiciosTransporte",
                column: "ClienteId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosTransporte_Vehiculos_VehiculoId",
                table: "ServiciosTransporte",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_ConductorId",
                table: "Vehiculos",
                column: "ConductorId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_DuenioId",
                table: "Vehiculos",
                column: "DuenioId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_MecanicoId",
                table: "Vehiculos",
                column: "MecanicoId",
                principalTable: "Personas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Revisones_Vehiculos_VehiculoId",
                table: "Revisones");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosTransporte_Personas_ClienteId",
                table: "ServiciosTransporte");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosTransporte_Vehiculos_VehiculoId",
                table: "ServiciosTransporte");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_ConductorId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_DuenioId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_MecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Revisones",
                table: "Revisones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "vehiculos");

            migrationBuilder.RenameTable(
                name: "Revisones",
                newName: "revisones");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personas");

            migrationBuilder.RenameColumn(
                name: "DuenioId",
                table: "vehiculos",
                newName: "DueñoId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_MecanicoId",
                table: "vehiculos",
                newName: "IX_vehiculos_MecanicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ConductorId",
                table: "vehiculos",
                newName: "IX_vehiculos_ConductorId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_DuenioId",
                table: "vehiculos",
                newName: "IX_vehiculos_DueñoId");

            migrationBuilder.RenameIndex(
                name: "IX_Revisones_VehiculoId",
                table: "revisones",
                newName: "IX_revisones_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_revisones",
                table: "revisones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_revisones_vehiculos_VehiculoId",
                table: "revisones",
                column: "VehiculoId",
                principalTable: "vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosTransporte_personas_ClienteId",
                table: "ServiciosTransporte",
                column: "ClienteId",
                principalTable: "personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosTransporte_vehiculos_VehiculoId",
                table: "ServiciosTransporte",
                column: "VehiculoId",
                principalTable: "vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_personas_ConductorId",
                table: "vehiculos",
                column: "ConductorId",
                principalTable: "personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_personas_DueñoId",
                table: "vehiculos",
                column: "DueñoId",
                principalTable: "personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_personas_MecanicoId",
                table: "vehiculos",
                column: "MecanicoId",
                principalTable: "personas",
                principalColumn: "Id");
        }
    }
}
