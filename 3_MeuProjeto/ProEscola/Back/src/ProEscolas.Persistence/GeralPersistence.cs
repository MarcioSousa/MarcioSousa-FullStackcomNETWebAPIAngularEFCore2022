using System.Threading.Tasks;
using ProEscolas.Persistence.Interfaces;

namespace ProEscolas.Persistence
{
    public class GeralPersistence : IGeralPersistence
    {
        private readonly ProEscolasContext _context;

        public GeralPersistence(ProEscolasContext context){
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}