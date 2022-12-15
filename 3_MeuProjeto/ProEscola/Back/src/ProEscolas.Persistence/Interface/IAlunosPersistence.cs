using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interface
{
    public interface IAlunosPersistence : IGeralPersistence
    {
         Task<Aluno[]> GetAllAlunosByIdAsync(string nome);
         Task<Aluno[]> GetAllAlunosAsync();
         Task<Aluno> GetAllAlunoByIdAsync(int alunoId);
    }
}