using System.Threading.Tasks;
using ProEscolas.Domain;

namespace ProEscolas.Persistence.Interfaces
{
    public interface IAPrazoPersistence : IGeralPersistence
    {
        Task<Aprazo[]> GetAllAprazosAsync();
        Task<Aprazo> GetAllAprazoByIdAsync(int aprazoId);
    }
}