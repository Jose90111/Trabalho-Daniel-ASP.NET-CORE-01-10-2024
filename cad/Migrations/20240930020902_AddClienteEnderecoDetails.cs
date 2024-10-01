using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cad.Migrations
{
    /// <inheritdoc />
    public partial class AddClienteEnderecoDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Clientes",
                newName: "Logradouro");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bairro", "CEP", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { "Centro", "01001-000", "São Paulo", "Apto 101", "SP", "Rua A", "123" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bairro", "CEP", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { "Jardim", "01002-000", "São Paulo", "", "SP", "Rua B", "456" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bairro", "CEP", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { "Vila Mariana", "01003-000", "São Paulo", "Bloco B", "SP", "Rua C", "789" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bairro", "CEP", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { "Liberdade", "01004-000", "São Paulo", "Casa 2", "SP", "Rua D", "101" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bairro", "CEP", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { "Santa Cecília", "01005-000", "São Paulo", "", "SP", "Rua E", "202" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Clientes",
                newName: "Endereco");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Endereco",
                value: "Rua A, 123");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Endereco",
                value: "Rua B, 456");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Endereco",
                value: "Rua C, 789");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Endereco",
                value: "Rua D, 101");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Endereco",
                value: "Rua E, 202");
        }
    }
}
