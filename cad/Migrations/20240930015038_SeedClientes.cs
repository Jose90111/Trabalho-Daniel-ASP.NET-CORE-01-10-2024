using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cad.Migrations
{
    /// <inheritdoc />
    public partial class SeedClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Email", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "joao@teste.com", "Rua A, 123", "João Silva", "11999999999" },
                    { 2, "maria@teste.com", "Rua B, 456", "Maria Souza", "11988888888" },
                    { 3, "carlos@teste.com", "Rua C, 789", "Carlos Lima", "11977777777" },
                    { 4, "ana@teste.com", "Rua D, 101", "Ana Costa", "11966666666" },
                    { 5, "pedro@teste.com", "Rua E, 202", "Pedro Marques", "11955555555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "Id");
        }
    }
}
