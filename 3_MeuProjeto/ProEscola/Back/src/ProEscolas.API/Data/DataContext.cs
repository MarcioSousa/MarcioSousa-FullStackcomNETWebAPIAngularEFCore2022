using Microsoft.EntityFrameworkCore;
using ProEscolas.API.Models;

namespace ProEscolas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Instrutor> Instrutores {get; set; }
        public DbSet<Turma> Turmas {get; set; }
        public DbSet<Curso> Cursos {get; set; }
        public DbSet<Matricula> Matriculas {get; set; }
        public DbSet<Avista> Avistas {get; set; }
        public DbSet<Aprazo> Aprazos {get; set; }

        //Configurando ligações muitos pra muitos.
        //protected override void OnModelCreating(ModelBuilder modelBuilder){
        //    modelBuilder.Entity<PalestranteEvento>().HasKey(PE => new {PE.EventoId, PE.PalestranteId});
        //}

    }
}
