using Microsoft.EntityFrameworkCore;
using ProEscola.API.Models;

namespace ProEscola.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet <Instrutor> Instrutores { get; set; }
    }
}