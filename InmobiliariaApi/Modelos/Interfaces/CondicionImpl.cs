using Microsoft.EntityFrameworkCore;
using Modelos.DataAccess.Context;
using Modelos.Models;

namespace Modelos.Interfaces
{
    public class CondicionImpl : ICondicion
    {
        public readonly ApplicationDbContext _context;

        public CondicionImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CondicionData>> GetAllCondicion()
        {
            return await _context.Condiciones.ToListAsync();
        }

        public async Task<CondicionData> GetCondicionById(int id)
        {
            return await _context.Condiciones.FindAsync(id);
        }
    }
}
