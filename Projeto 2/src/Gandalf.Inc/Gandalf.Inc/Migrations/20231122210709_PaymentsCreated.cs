using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gandalf.Inc.Migrations
{
    public partial class PaymentsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroFatura = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroPontoDeVenda = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataModificacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pago = table.Column<bool>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblVendas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblVendas_tblUsuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "tblUsuarios",
                        principalColumn: "fldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPagamentos",
                columns: table => new
                {
                    fldIdPagamento = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendaId = table.Column<int>(type: "INTEGER", nullable: true),
                    ValorPago = table.Column<decimal>(type: "TEXT", nullable: false),
                    TipoPagamento = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPagamentos", x => x.fldIdPagamento);
                    table.ForeignKey(
                        name: "FK_tblPagamentos_tblVendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "tblVendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPagamentos_VendaId",
                table: "tblPagamentos",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVendas_ClienteId",
                table: "tblVendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVendas_UsuarioId",
                table: "tblVendas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPagamentos");

            migrationBuilder.DropTable(
                name: "tblVendas");
        }
    }
}
