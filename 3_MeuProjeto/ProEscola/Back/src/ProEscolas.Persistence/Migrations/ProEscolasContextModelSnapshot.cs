﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProEscolas.Persistence.Migrations
{
    [DbContext(typeof(ProEscolasContext))]
    partial class ProEscolasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ProEscolas.Domain.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("DataNasc")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Escolaridade")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Centro",
                            Celular = "11922211111",
                            Cep = "11222-111",
                            Cidade = "Itu",
                            Cpf = "123.456.789-22",
                            DataNasc = "01/09/2000",
                            Email = "teste2@teste.com",
                            Endereco = "Rua AA",
                            Escolaridade = "Ensino Médio",
                            Estado = "SP",
                            EstadoCivil = "Casado",
                            Nome = "João",
                            Numero = 17,
                            Rg = "11.111.222-22",
                            Sexo = "M",
                            Telefone = "5555511111"
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Centro",
                            Celular = "33911111111",
                            Cep = "31111-111",
                            Cidade = "Itu",
                            Cpf = "012.645.201-77",
                            DataNasc = "01/01/1990",
                            Email = "teste3@teste.com",
                            Endereco = "Rua M",
                            Escolaridade = "Ensino Superior",
                            Estado = "RJ",
                            EstadoCivil = "Solteiro",
                            Nome = "Marcio",
                            Numero = 15,
                            Rg = "33.111.111-11",
                            Sexo = "M",
                            Telefone = "3311111111"
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Aprazo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DtVencimento")
                        .HasColumnType("longtext");

                    b.Property<int?>("MatriculaId")
                        .HasColumnType("int");

                    b.Property<int>("QtdeMensalidade")
                        .HasColumnType("int");

                    b.Property<double>("TaxaJuros")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MatriculaId");

                    b.ToTable("Aprazos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DtVencimento = "05/05/2022",
                            MatriculaId = 1,
                            QtdeMensalidade = 3,
                            TaxaJuros = 5.5999999999999996,
                            Valor = 322.60000000000002
                        },
                        new
                        {
                            Id = 2,
                            DtVencimento = "05/05/2022",
                            MatriculaId = 2,
                            QtdeMensalidade = 3,
                            TaxaJuros = 5.5999999999999996,
                            Valor = 322.60000000000002
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Avista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Agencia")
                        .HasColumnType("int");

                    b.Property<int?>("MatriculaId")
                        .HasColumnType("int");

                    b.Property<int>("NCheque")
                        .HasColumnType("int");

                    b.Property<string>("PreData")
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MatriculaId");

                    b.ToTable("Avistas");
                });

            modelBuilder.Entity("ProEscolas.Domain.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<string>("DataVigencia")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Programa")
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.Property<double>("ValorHoraInstrutor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 20,
                            DataVigencia = "02/03/2022",
                            Nome = "Analista",
                            Programa = "Planilhas",
                            Sigla = "AAA",
                            Valor = 850.29999999999995,
                            ValorHoraInstrutor = 125.3
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 30,
                            DataVigencia = "22/10/2022",
                            Nome = "Junior",
                            Programa = "Residêncial",
                            Sigla = "BBC",
                            Valor = 743.20000000000005,
                            ValorHoraInstrutor = 100.59999999999999
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Instrutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AreaAtuacao")
                        .HasColumnType("longtext");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("DataNasc")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("longtext");

                    b.Property<string>("Formacao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instrutores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AreaAtuacao = "Administração",
                            Bairro = "Centro",
                            Celular = "11911111111",
                            Cep = "11111-111",
                            Cidade = "Sorocaba",
                            Cpf = "1",
                            DataNasc = "01/01/2000",
                            Email = "teste1@teste.com",
                            Endereco = "Rua J",
                            Estado = "RJ",
                            EstadoCivil = "Solteiro",
                            Formacao = "Ensino Médio",
                            Nome = "Roberto",
                            Numero = 10,
                            Rg = "11.111.111-11",
                            Sexo = "M",
                            Telefone = "1111111111"
                        },
                        new
                        {
                            Id = 2,
                            AreaAtuacao = "Eletrecista",
                            Bairro = "Centro",
                            Celular = "22911111111",
                            Cep = "22222-111",
                            Cidade = "Jundiaí",
                            Cpf = "2",
                            DataNasc = "01/01/2001",
                            Email = "teste2@teste.com",
                            Endereco = "Rua A",
                            Estado = "SP",
                            EstadoCivil = "Solteiro",
                            Formacao = "Ensino Fundamental",
                            Nome = "Ana",
                            Numero = 101,
                            Rg = "11.111.111-22",
                            Sexo = "F",
                            Telefone = "2211111111"
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<double>("Nota")
                        .HasColumnType("double");

                    b.Property<int>("QtdeFaltas")
                        .HasColumnType("int");

                    b.Property<int?>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Matriculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlunoId = 2,
                            Data = "17/12/2022 20:36:16",
                            Nota = 7.7999999999999998,
                            QtdeFaltas = 7,
                            TurmaId = 1
                        },
                        new
                        {
                            Id = 2,
                            AlunoId = 1,
                            Data = "17/12/2022 20:36:16",
                            Nota = 2.6000000000000001,
                            QtdeFaltas = 3,
                            TurmaId = 2
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("DataInicio")
                        .HasColumnType("longtext");

                    b.Property<string>("DataTermino")
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int?>("InstrutorId")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext");

                    b.Property<string>("Periodo")
                        .HasColumnType("longtext");

                    b.Property<int>("QtdeVagas")
                        .HasColumnType("int");

                    b.Property<string>("SiglaTurma")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("InstrutorId");

                    b.ToTable("Turmas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CursoId = 1,
                            DataInicio = "02/02/2022",
                            DataTermino = "02/10/2022",
                            Descricao = "Analistas de Sistemas",
                            InstrutorId = 1,
                            Observacoes = "Terá um mês de férias.",
                            Periodo = "Manhã",
                            QtdeVagas = 20,
                            SiglaTurma = "AA10"
                        },
                        new
                        {
                            Id = 2,
                            CursoId = 2,
                            DataInicio = "02/03/2022",
                            DataTermino = "02/06/2022",
                            Descricao = "Bolos e Confeitos",
                            InstrutorId = 2,
                            Observacoes = "Não terá um mês de férias.",
                            Periodo = "Tarde",
                            QtdeVagas = 5,
                            SiglaTurma = "BB01"
                        });
                });

            modelBuilder.Entity("ProEscolas.Domain.Aprazo", b =>
                {
                    b.HasOne("ProEscolas.Domain.Matricula", "Matricula")
                        .WithMany()
                        .HasForeignKey("MatriculaId");

                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("ProEscolas.Domain.Avista", b =>
                {
                    b.HasOne("ProEscolas.Domain.Matricula", "Matricula")
                        .WithMany()
                        .HasForeignKey("MatriculaId");

                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("ProEscolas.Domain.Matricula", b =>
                {
                    b.HasOne("ProEscolas.Domain.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("ProEscolas.Domain.Turma", "Turma")
                        .WithMany("Matriculas")
                        .HasForeignKey("TurmaId");

                    b.Navigation("Aluno");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("ProEscolas.Domain.Turma", b =>
                {
                    b.HasOne("ProEscolas.Domain.Curso", "Curso")
                        .WithMany("Turmas")
                        .HasForeignKey("CursoId");

                    b.HasOne("ProEscolas.Domain.Instrutor", "Instrutor")
                        .WithMany("Turmas")
                        .HasForeignKey("InstrutorId");

                    b.Navigation("Curso");

                    b.Navigation("Instrutor");
                });

            modelBuilder.Entity("ProEscolas.Domain.Curso", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("ProEscolas.Domain.Instrutor", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("ProEscolas.Domain.Turma", b =>
                {
                    b.Navigation("Matriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
