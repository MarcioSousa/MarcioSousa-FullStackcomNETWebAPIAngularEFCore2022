using System.Threading.Tasks;
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

        public Task<Aluno> GetAllAlunoByIdAsync(int AlunoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAllAlunosAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAllAlunosByIdAsync(int AlunoId)
        {
            throw new System.NotImplementedException();
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