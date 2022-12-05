using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface IInMueble
    {
        Task<List<InmuebleData>> GetAllInmuebles();
        Task<InmuebleData> GetInmueble(int id);
        Task<InmuebleData> PostInmueble(InmuebleData inmueble);
        Task<bool> DeleteInmueble(InmuebleData inmueble);
        Task<bool> UpdateInmueble(InmuebleData inmueble);
    }
}
