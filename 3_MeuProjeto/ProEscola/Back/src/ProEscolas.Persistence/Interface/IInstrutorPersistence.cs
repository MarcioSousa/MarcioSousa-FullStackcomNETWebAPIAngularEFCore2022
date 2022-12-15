using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interface
{
    public interface IInstrutorPersistence : IGeralPersistence
    {
        Task<Instrutor[]> GetAllInstrutorsByIdAsync(string nome);
        Task<Instrutor[]> GetAllInstrutorsAsync();
        Task<Instrutor> GetAllInstrutorByIdAsync(int instrutorId);
    }
}