using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interface
{
    public interface IMatriculaPersistence : IGeralPersistence
    {
        Task<Matricula[]> GetAllMatriculasByIdAsync(string alunoId);
        Task<Matricula[]> GetAllMatriculasAsync();
        Task<Matricula> GetAllMatriculaByIdAsync(int matriculaId);
    }
}