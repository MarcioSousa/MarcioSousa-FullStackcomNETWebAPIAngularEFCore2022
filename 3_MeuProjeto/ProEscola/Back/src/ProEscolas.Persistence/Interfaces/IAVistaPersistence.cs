using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interfaces
{
    public interface IAVistaPersistence : IGeralPersistence
    {
        Task<Avista[]> GetAllAvistasAsync();
        Task<Avista> GetAllAvistaByIdAsync(int avistaId);
    }
}