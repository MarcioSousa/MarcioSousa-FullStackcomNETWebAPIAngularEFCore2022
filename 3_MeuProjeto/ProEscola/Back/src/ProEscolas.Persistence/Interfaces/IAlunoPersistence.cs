using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interfaces
{
    public interface IAlunoPersistence 
    {
         Task<Aluno[]> Get(string nome);
         Task<Aluno[]> Get();
         Task<Aluno> Get(int alunoId);
    }
}