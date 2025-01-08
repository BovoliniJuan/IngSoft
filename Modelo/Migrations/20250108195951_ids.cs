using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class ids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "Persona",
                newName: "Telefono");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Persona",
                newName: "IdVendedor");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Persona",
                type: "int",
                nullable: true);
        }
    }
}
