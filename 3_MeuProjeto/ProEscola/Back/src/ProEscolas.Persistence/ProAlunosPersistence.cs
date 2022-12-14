using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEscolas.Domain;

namespace ProEscolas.Persistence
{
    public class ProAlunosPersistence : IProAlunosPersistence
    {
      
        private readonly ProEscolasContext _context;
        public ProAlunosPersistence(ProEscolasContext context)
        {
            context = _context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<Aluno> GetAllAlunoByIdAsync(int alunoId)
        {
            IQueryable<Aluno> query = _context.Alunos;

            query = query.OrderBy(e => e.Id).Where(e => e.Id == alunoId);
            
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Aluno[]> GetAllAlunosAsync()
        {
            //IQueryable<Aluno> query = _context.Alunos.Include( e => e.Lotes).Include(e => e.RedesSociais);
            
            //if(includePalestrante){
            //    query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Palestrante);
            //}
            
            IQueryable<Aluno> query = _context.Alunos;

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Aluno[]> GetAllAlunosByIdAsync(string nome)
        {
            IQueryable<Aluno> query = _context.Alunos;

            query = query.OrderBy(e => e.Id).Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
            
            return await query.ToArrayAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return(await _context.SaveChangesAsync()) > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }

}