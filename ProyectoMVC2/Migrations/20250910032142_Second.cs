using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMVC2.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "echaPedido",
                table: "Pedidos",
                newName: "FechaPedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaPedido",
                table: "Pedidos",
                newName: "echaPedido");
        }
    }
}
