using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interface
{
    public interface ICursoPersistence : IGeralPersistence
    {
        Task<Curso[]> GetAllCursosByIdAsync(string nome);
        Task<Curso[]> GetAllCursosAsync();
        Task<Curso> GetAllCursoByIdAsync(int cursoId);
    }
}