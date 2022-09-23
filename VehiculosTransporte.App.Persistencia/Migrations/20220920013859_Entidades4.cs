using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiculosTransporte.App.Persistencia.Migrations
{
    public partial class Entidades4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Revisones_Vehiculos_VehiculoId",
                table: "Revisones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Revisones",
                table: "Revisones");

            migrationBuilder.RenameTable(
                name: "Revisones",
                newName: "Revisiones");

            migrationBuilder.RenameIndex(
                name: "IX_Revisones_VehiculoId",
                table: "Revisiones",
                newName: "IX_Revisiones_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Revisiones",
                table: "Revisiones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Revisiones_Vehiculos_VehiculoId",
                table: "Revisiones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Revisiones_Vehiculos_VehiculoId",
                table: "Revisiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Revisiones",
                table: "Revisiones");

            migrationBuilder.RenameTable(
                name: "Revisiones",
                newName: "Revisones");

            migrationBuilder.RenameIndex(
                name: "IX_Revisiones_VehiculoId",
                table: "Revisones",
                newName: "IX_Revisones_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Revisones",
                table: "Revisones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Revisones_Vehiculos_VehiculoId",
                table: "Revisones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }
    }
}
