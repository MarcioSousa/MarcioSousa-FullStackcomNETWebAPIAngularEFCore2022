using Microsoft.EntityFrameworkCore;
using ProEscolas.API.Models;

namespace ProEscolas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
    }
}