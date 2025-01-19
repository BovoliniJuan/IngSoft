using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class CambiosEstadoPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidoIdEstadoPedido",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "EstadoPedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_EstadoPedidoIdEstadoPedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "EstadoPedidoIdEstadoPedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "EstadoPedidoIdEstadoPedido",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoPedidos",
                columns: table => new
                {
                    IdEstadoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedidos", x => x.IdEstadoPedido);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadoPedidoIdEstadoPedido",
                table: "Pedidos",
                column: "EstadoPedidoIdEstadoPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidoIdEstadoPedido",
                table: "Pedidos",
                column: "EstadoPedidoIdEstadoPedido",
                principalTable: "EstadoPedidos",
                principalColumn: "IdEstadoPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
