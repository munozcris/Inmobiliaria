using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface IVenta
    {
        Task<List<VentaData>> GetAllVentas();
        Task<VentaData> GetVenta(int id);
        Task<VentaData> PostVenta(VentaData venta);
        Task<bool> DeleteVenta(VentaData venta);
        // Task<bool> UpdateVenta(VentaData venta);
    }
}
