using Microsoft.EntityFrameworkCore;
using Modelos.DataAccess.Context;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Interfaces
{
    public class TipoInmuebleImpl : ITipoInmueble
    {
        private readonly ApplicationDbContext _context;

        public TipoInmuebleImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoInmuebleData>> GetAllTipoInmueble()
        {
            return await _context.Tipos.ToListAsync();
        }

        public async Task<TipoInmuebleData> GetTipo(int id)
        {
            return await _context.Tipos.FindAsync(id);
        }

        public async Task<TipoInmuebleData> GetTipoInmueble(int id)
        {
            return await _context.Tipos.FindAsync(id);
        }
    }
}
