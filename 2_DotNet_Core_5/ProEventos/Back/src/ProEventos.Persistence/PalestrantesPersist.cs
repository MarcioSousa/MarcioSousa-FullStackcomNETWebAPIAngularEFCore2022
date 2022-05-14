using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class PalestrantesPersist : IPalestrantePersist
    {
        private readonly ProEventosContext _context;

        public PalestrantesPersist(ProEventosContext _context)
        {
            this._context = _context;
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);
           
            if(includeEventos){
                query = query.Include(p => p.PalestrantesEventos).ThenInclude(e => e.Evento);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id);
            
            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);
           
            if(includeEventos){
                query = query.Include(p => p.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
            
            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);
           
            if(includeEventos){
                query = query.Include(p => p.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Id == PalestranteId);
            
            return await query.FirstOrDefaultAsync();
        }

    }
}