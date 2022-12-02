using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface IVenta
    {
        Task<List<VentaData>> GetAllVentas();
    }
}
