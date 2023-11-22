using Microsoft.EntityFrameworkCore.Migrations;

namespace Gandalf.Inc.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPagamento",
                table: "tblPagamentos");

            migrationBuilder.AddColumn<int>(
                name: "LojaId",
                table: "tblVendas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PontoDeVendafldPosID",
                table: "tblVendas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LojaId",
                table: "tblPagamentos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tblPaymentType",
                columns: table => new
                {
                    fldPaymentTypeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fldPaymentType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentType", x => x.fldPaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbPos",
                columns: table => new
                {
                    fldPosID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fldStoreId = table.Column<int>(type: "INTEGER", nullable: true),
                    fldStoreLocation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPos", x => x.fldPosID);
                    table.ForeignKey(
                        name: "FK_tbPos_tblLojas_fldStoreId",
                        column: x => x.fldStoreId,
                        principalTable: "tblLojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblVendas_LojaId",
                table: "tblVendas",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVendas_PontoDeVendafldPosID",
                table: "tblVendas",
                column: "PontoDeVendafldPosID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPagamentos_LojaId",
                table: "tblPagamentos",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPagamentos_TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos",
                column: "TipoPagamentofldPaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPos_fldStoreId",
                table: "tbPos",
                column: "fldStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPagamentos_tblLojas_LojaId",
                table: "tblPagamentos",
                column: "LojaId",
                principalTable: "tblLojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPagamentos_tblPaymentType_TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos",
                column: "TipoPagamentofldPaymentTypeID",
                principalTable: "tblPaymentType",
                principalColumn: "fldPaymentTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblVendas_tblLojas_LojaId",
                table: "tblVendas",
                column: "LojaId",
                principalTable: "tblLojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblVendas_tbPos_PontoDeVendafldPosID",
                table: "tblVendas",
                column: "PontoDeVendafldPosID",
                principalTable: "tbPos",
                principalColumn: "fldPosID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPagamentos_tblLojas_LojaId",
                table: "tblPagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPagamentos_tblPaymentType_TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_tblVendas_tblLojas_LojaId",
                table: "tblVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_tblVendas_tbPos_PontoDeVendafldPosID",
                table: "tblVendas");

            migrationBuilder.DropTable(
                name: "tblPaymentType");

            migrationBuilder.DropTable(
                name: "tbPos");

            migrationBuilder.DropIndex(
                name: "IX_tblVendas_LojaId",
                table: "tblVendas");

            migrationBuilder.DropIndex(
                name: "IX_tblVendas_PontoDeVendafldPosID",
                table: "tblVendas");

            migrationBuilder.DropIndex(
                name: "IX_tblPagamentos_LojaId",
                table: "tblPagamentos");

            migrationBuilder.DropIndex(
                name: "IX_tblPagamentos_TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "tblVendas");

            migrationBuilder.DropColumn(
                name: "PontoDeVendafldPosID",
                table: "tblVendas");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "tblPagamentos");

            migrationBuilder.DropColumn(
                name: "TipoPagamentofldPaymentTypeID",
                table: "tblPagamentos");

            migrationBuilder.AddColumn<string>(
                name: "TipoPagamento",
                table: "tblPagamentos",
                type: "TEXT",
                maxLength: 50,
                nullable: true);
        }
    }
}
