using Microsoft.EntityFrameworkCore;
using cad.Models;

namespace cad.Data
{
    public class AppCont : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public AppCont(DbContextOptions<AppCont> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,Nome = "Lucas Almeida",Telefone = "31933333333",Email = "lucas@teste.com",Logradouro = "Rua G",Numero = "111",Complemento = "Apto 402",Bairro = "Funcionários",Cidade = "Belo Horizonte",Estado = "MG",CEP = "30107-000"
                },
                new Cliente
                {
                    Id = 2,Nome = "Juliana Santos",Telefone = "41922222222",Email = "juliana@teste.com",Logradouro = "Avenida H",Numero = "222",Complemento = "Bloco B",Bairro = "Centro Cívico",Cidade = "Curitiba",Estado = "PR",CEP = "80010-000"
                },
                new Cliente
                {
                    Id = 3,Nome = "Ricardo Fernandes",Telefone = "41911111111",Email = "ricardo@teste.com",Logradouro = "Rua I",Numero = "333",Complemento = "Casa 3",Bairro = "Batel",Cidade = "Curitiba",Estado = "PR",CEP = "80420-000"
                },
                new Cliente
                {
                    Id = 4,Nome = "Patrícia Mello",Telefone = "51999999999",Email = "patricia@teste.com",Logradouro = "Rua J",Numero = "444",Complemento = "Apto 504",Bairro = "Moinhos de Vento",Cidade = "Porto Alegre",Estado = "RS",CEP = "90520-000"
                },
                new Cliente
                {
                    Id = 5,Nome = "Thiago Nascimento",Telefone = "51988888888",Email = "thiago@teste.com",Logradouro = "Avenida K",Numero = "555",Complemento = "Bloco 1",Bairro = "Centro",Cidade = "Porto Alegre",Estado = "RS",CEP = "90010-000"
                }
            );
        }
    }
}
