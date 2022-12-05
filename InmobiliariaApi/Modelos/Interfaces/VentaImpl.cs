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
    public class VentaImpl : IVenta
    {
        public readonly ApplicationDbContext  _context;
        public ICondicion _condicion;


        public VentaImpl(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<bool> DeleteVenta(VentaData venta)
        {
            _context.Ventas.Remove(venta);
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

        public async Task<List<VentaData>> GetAllVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<VentaData> GetVenta(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        public async Task<VentaData> PostVenta(VentaData venta)
        {
            venta.CondicionData = await _condicion.GetCondicionById(2);
            venta.TotalVenta = venta.InmuebleData.costo_inmueble;
            venta.Total_iva = venta.TotalVenta * 21 / 100;
            venta.Total_general = venta.TotalVenta + venta.Total_iva;
            _context.Ventas.Add(venta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return venta;
        }
    }
}
