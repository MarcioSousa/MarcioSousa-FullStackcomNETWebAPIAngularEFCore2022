using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Application.Services
{
    public interface IAlunosService
    {
        Task<Aluno> Add(Aluno model);
        Task<Aluno> Update(int alunoId, Aluno model);
        Task<bool> Delete(int alunoId);

        Task<Aluno[]> Get(string nome);
        Task<Aluno[]> Get();
        Task<Aluno> Get(int alunoId);
    }
}