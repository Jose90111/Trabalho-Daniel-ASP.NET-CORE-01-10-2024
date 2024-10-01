﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cad.Data;

#nullable disable

namespace cad.Migrations
{
    [DbContext(typeof(AppCont))]
    [Migration("20240930015038_SeedClientes")]
    partial class SeedClientes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cad.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "joao@teste.com",
                            Endereco = "Rua A, 123",
                            Nome = "João Silva",
                            Telefone = "11999999999"
                        },
                        new
                        {
                            Id = 2,
                            Email = "maria@teste.com",
                            Endereco = "Rua B, 456",
                            Nome = "Maria Souza",
                            Telefone = "11988888888"
                        },
                        new
                        {
                            Id = 3,
                            Email = "carlos@teste.com",
                            Endereco = "Rua C, 789",
                            Nome = "Carlos Lima",
                            Telefone = "11977777777"
                        },
                        new
                        {
                            Id = 4,
                            Email = "ana@teste.com",
                            Endereco = "Rua D, 101",
                            Nome = "Ana Costa",
                            Telefone = "11966666666"
                        },
                        new
                        {
                            Id = 5,
                            Email = "pedro@teste.com",
                            Endereco = "Rua E, 202",
                            Nome = "Pedro Marques",
                            Telefone = "11955555555"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
