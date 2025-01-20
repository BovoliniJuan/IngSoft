using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class vendero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vendedores_VendedorIdPersona",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "VendedorIdPersona",
                table: "Pedidos",
                newName: "idVendedor");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_VendedorIdPersona",
                table: "Pedidos",
                newName: "IX_Pedidos_idVendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vendedores_idVendedor",
                table: "Pedidos",
                column: "idVendedor",
                principalTable: "Vendedores",
                principalColumn: "IdVendedor",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vendedores_idVendedor",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "idVendedor",
                table: "Pedidos",
                newName: "VendedorIdPersona");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_idVendedor",
                table: "Pedidos",
                newName: "IX_Pedidos_VendedorIdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vendedores_VendedorIdPersona",
                table: "Pedidos",
                column: "VendedorIdPersona",
                principalTable: "Vendedores",
                principalColumn: "IdVendedor",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
