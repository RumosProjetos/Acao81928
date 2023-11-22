using Microsoft.EntityFrameworkCore.Migrations;

namespace Gandalf.Inc.Migrations
{
    public partial class ClientesTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblVendas_Clientes_ClienteId",
                table: "tblVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Lojas",
                newName: "tblLojas");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "tblClientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblLojas",
                table: "tblLojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblClientes",
                table: "tblClientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblVendas_tblClientes_ClienteId",
                table: "tblVendas",
                column: "ClienteId",
                principalTable: "tblClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblVendas_tblClientes_ClienteId",
                table: "tblVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblLojas",
                table: "tblLojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblClientes",
                table: "tblClientes");

            migrationBuilder.RenameTable(
                name: "tblLojas",
                newName: "Lojas");

            migrationBuilder.RenameTable(
                name: "tblClientes",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblVendas_Clientes_ClienteId",
                table: "tblVendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
