using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEscolas.Domain;
using ProEscolas.Persistence.Interfaces;

namespace ProEscolas.Persistence
{
    public class AlunoPersistence : IAlunoPersistence
    {
        private readonly ProEscolasContext _context;
        
        public AlunoPersistence(ProEscolasContext context)
        {
            context = _context;
        }

        public async Task<Aluno[]> Get(string nome)
        {
            IQueryable<Aluno> query = _context.Alunos;
            
            query = query.OrderBy(e => e.Id).Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
            
            return await query.ToArrayAsync();
        }

        public async Task<Aluno[]> Get()
        {
            IQueryable<Aluno> query = _context.Alunos;
            
            query = query.OrderBy(e => e.Id);
            
            return await query.ToArrayAsync();
        }

        public async Task<Aluno> Get(int alunoId)
        {
            IQueryable<Aluno> query = _context.Alunos;
            
            query = query.OrderBy(e => e.Id).Where(e => e.Id == alunoId);
            
            return await query.FirstOrDefaultAsync();
        }
        
    }

}