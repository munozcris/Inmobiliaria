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

        public async Task<bool> DeleteCliente(ClienteData cliente)
        {
            _context.Cliente.Remove(cliente);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<List<ClienteData>> GetAllClientes()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<ClienteData> GetCliente(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            return cliente;
        }

        public async Task<ClienteData> PostCliente(ClienteData cliente)
        {
            _context.Cliente.Add(cliente);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return cliente;
        }

        public async Task<bool> UpdateCliente(ClienteData cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
