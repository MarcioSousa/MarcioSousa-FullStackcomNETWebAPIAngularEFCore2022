using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence
{
    public interface IProAlunosPersistence
    {
        void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         void DeleteRange<T>(T entity) where T: class;

         Task<bool> SaveChangesAsync();

         //Eventos
         Task<Aluno[]> GetAllAlunosByIdAsync(int AlunoId);
         Task<Aluno[]> GetAllAlunosAsync();
         Task<Aluno> GetAllAlunoByIdAsync(int AlunoId);
    }
}