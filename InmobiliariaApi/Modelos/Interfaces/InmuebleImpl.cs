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
    public class InmuebleImpl : IInMueble
    {
        private readonly ApplicationDbContext _context;

        public InmuebleImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteInmueble(InmuebleData inmueble)
        {
            _context.Inmuebles.Remove(inmueble);
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

        public async Task<List<InmuebleData>> GetAllInmuebles()
        {
            return await _context.Inmuebles.ToListAsync();
        }

        public async Task<InmuebleData> GetInmueble(int id)
        {
            return await _context.Inmuebles.FindAsync(id);
        }

        public async Task<InmuebleData> PostInmueble(InmuebleData inmueble)
        {

            _context.Inmuebles.Add(inmueble);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return inmueble;
        }

        public async Task<bool> UpdateInmueble(InmuebleData inmueble)
        {
            _context.Entry(inmueble).State = EntityState.Modified;
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
