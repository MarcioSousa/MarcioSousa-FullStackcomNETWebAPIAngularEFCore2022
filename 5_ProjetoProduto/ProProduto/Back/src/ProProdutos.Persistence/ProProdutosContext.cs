using Microsoft.EntityFrameworkCore;
using ProProdutos.Domain;

namespace ProProdutos.Persistence
{
    public class ProProdutosContext : DbContext
    {
        public ProProdutosContext
                    (DbContextOptions<ProProdutosContext> options) 
                    : base(options) { }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            Fabricante fab1 = new Fabricante();
            fab1.Id = 1;
            fab1.Nome = "Sansung";

            Fabricante fab2 = new Fabricante();
            fab2.Id = 2;
            fab2.Nome = "Motorola";

            Categoria cat1 = new Categoria();
            cat1.Id = 1;
            cat1.Nome = "Eletrodomestico";

            Categoria cat2 = new Categoria();
            cat2.Id = 2;
            cat2.Nome = "Escolar";

            Produto prod1 = new Produto();
            prod1.Id = 1;
            prod1.Nome = "Celular";
            prod1.CategoriaId = cat1.Id;
            prod1.FabricanteId = fab1.Id;

            Produto prod2 = new Produto();
            prod2.Id = 2;
            prod2.Nome = "Notebook";
            prod2.CategoriaId = cat2.Id;
            prod2.FabricanteId = fab1.Id;

            Produto prod3 = new Produto();
            prod3.Id = 3;
            prod3.Nome = "Caneta";
            prod3.CategoriaId = cat2.Id;
            prod3.FabricanteId = fab2.Id;

            modelBuilder.Entity<Produto>().HasData(prod1, prod2, prod3);
            modelBuilder.Entity<Categoria>().HasData(cat1, cat2);
            modelBuilder.Entity<Fabricante>().HasData(fab1, fab2);

        }

    }
}