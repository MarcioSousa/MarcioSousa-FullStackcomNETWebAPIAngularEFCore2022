using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interfaces
{
    public interface IInstrutorPersistence : IGeralPersistence
    {
        Task<Instrutor[]> GetAllInstrutorsByIdAsync(string nome);
        Task<Instrutor[]> GetAllInstrutorsAsync();
        Task<Instrutor> GetAllInstrutorByIdAsync(int instrutorId);
    }
}