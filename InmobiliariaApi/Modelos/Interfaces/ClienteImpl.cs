using Microsoft.EntityFrameworkCore;
using Modelos.DataAccess.Context;
using Modelos.Models;

namespace Modelos.Interfaces
{
    public class ClienteImpl : ICliente
    {
        public readonly ApplicationDbContext _context;

        public ClienteImpl(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ClienteData>> GetAllClientes()
        {
            return await _context.Cliente.ToListAsync();
        }
    }
}
