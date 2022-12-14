using System.Collections.Generic;

namespace ProProdutos.Domain
{
    public class Fabricante
    {
        public int Id { get; set; }    
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public Fabricante() { }
        
    }
}