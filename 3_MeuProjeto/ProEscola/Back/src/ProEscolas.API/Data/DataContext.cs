using System;
using Microsoft.EntityFrameworkCore;
using ProEscolas.API.Models;

namespace ProEscolas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Avista> Avistas { get; set; }
        public DbSet<Aprazo> Aprazos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Curso curso1 = new("AAA", "Analista")
            {
                CursoId = 1,
                CargaHoraria = 20,
                DataVigencia = "02/03/2022",
                Nome = "Analista",
                Programa = "Planilhas",
                Sigla = "AAA",
                Valor = 850.30,
                ValorHoraInstrutor = 125.30
            };
            Curso curso2 = new("BBB", "Eletrecista")
            {
                CursoId = 2,
                CargaHoraria = 30,
                DataVigencia = "22/10/2022",
                Nome = "Junior",
                Programa = "Residêncial",
                Sigla = "BBC",
                Valor = 743.20,
                ValorHoraInstrutor = 100.60
            };

            Instrutor instrutor1 = new Instrutor("1", "Roberto")
            {
                InstrutorId = 1,
                DataNasc = "01/01/2000",
                Endereco = "Rua J",
                Numero = 10,
                Bairro = "Centro",
                Cidade = "Sorocaba",
                Estado = "RJ",
                Cep = "11111-111",
                Telefone = "1111111111",
                Celular = "11911111111",
                Sexo = "M",
                EstadoCivil = "Solteiro",
                Rg = "11.111.111-11",
                Email = "teste1@teste.com",
                Formacao = "Ensino Médio",
                AreaAtuacao = "Administração"
            };  
            Instrutor instrutor2 = new Instrutor("2", "Ana")
            {
                InstrutorId = 2,
                DataNasc = "01/01/2001",
                Endereco = "Rua A",
                Numero = 101,
                Bairro = "Centro",
                Cidade = "Jundiaí",
                Estado = "SP",
                Cep = "22222-111",
                Telefone = "2211111111",
                Celular = "22911111111",
                Sexo = "F",
                EstadoCivil = "Solteiro",
                Rg = "11.111.111-22",
                Email = "teste2@teste.com",
                Formacao = "Ensino Fundamental",
                AreaAtuacao = "Eletrecista"
            };

            Turma turma1 = new("ADS", "Analista e Desenvolvimento de Sistemas")
            {
                TurmaId = 1,
                CursoId = curso1.CursoId,
                InstrutorId = instrutor1.InstrutorId,
                DataInicio = "02/02/2022",
                DataTermino = "02/10/2022",
                Descricao = "Analistas de Sistemas",
                Observacoes = "Terá um mês de férias.",
                Periodo = "Manhã",
                QtdeVagas = 20,
                SiglaTurma = "AA10"
            };
            Turma turma2 = new("ABB", "Eletrecista Residêncial")
            {
                TurmaId = 2,
                CursoId = curso2.CursoId,
                InstrutorId = instrutor2.InstrutorId,
                DataInicio = "02/03/2022",
                DataTermino = "02/06/2022",
                Descricao = "Bolos e Confeitos",
                Observacoes = "Não terá um mês de férias.",
                Periodo = "Tarde",
                QtdeVagas = 5,
                SiglaTurma = "BB01"
            };

            Aluno aluno1 = new("123.456.789-22", "João")
            {
                AlunoId = 1,
                DataNasc = "01/09/2000",
                Endereco = "Rua AA",
                Numero = 17,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "SP",
                Cep = "11222-111",
                Telefone = "5555511111",
                Celular = "11922211111",
                Sexo = "M",
                EstadoCivil = "Casado",
                Rg = "11.111.222-22",
                Email = "teste2@teste.com",
                Escolaridade = "Ensino Médio"
            };
            Aluno aluno2 = new("012.645.201-77", "Marcio")
            {
                AlunoId = 2,
                DataNasc = "01/01/1990",
                Endereco = "Rua M",
                Numero = 15,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "RJ",
                Cep = "31111-111",
                Telefone = "3311111111",
                Celular = "33911111111",
                Sexo = "M",
                EstadoCivil = "Solteiro",
                Rg = "33.111.111-11",
                Email = "teste3@teste.com",
                Escolaridade = "Ensino Superior"
            };

            Matricula matricula1 = new(DateTime.Now.ToString())
            {
                MatriculaId = 1,
                TurmaId = turma1.TurmaId,
                Nota = 7.8,
                QtdeFaltas = 7,
                AlunoId = aluno2.AlunoId
            };

            Aprazo aprazo1 = new(322.60, 3, 5.6, "05/05/2022")
            {
                AprazoId = 1,
                MatriculaId = matricula1.MatriculaId
            };

            modelBuilder.Entity<Curso>().HasData(curso1, curso2);
            modelBuilder.Entity<Turma>().HasData(turma1, turma2);
            modelBuilder.Entity<Aluno>().HasData(aluno1, aluno2);
            modelBuilder.Entity<Instrutor>().HasData(instrutor1, instrutor2);
            modelBuilder.Entity<Matricula>().HasData(matricula1);
            modelBuilder.Entity<Aprazo>().HasData(aprazo1);

        }
    }
}