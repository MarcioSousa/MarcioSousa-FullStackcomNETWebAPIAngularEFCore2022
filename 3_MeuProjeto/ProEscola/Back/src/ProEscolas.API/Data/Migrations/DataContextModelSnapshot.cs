﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEscolas.API.Data;

namespace ProEscolas.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ProEscolas.API.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Escolaridade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rg")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
