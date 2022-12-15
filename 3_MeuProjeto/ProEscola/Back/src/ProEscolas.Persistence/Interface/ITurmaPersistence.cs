using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interface
{
    public interface ITurmaPersistence : IGeralPersistence
    {
        Task<Turma[]> GetAllTurmasAsync();
        Task<Turma> GetAllTurmaByIdAsync(int siglaTurma);
    }
}