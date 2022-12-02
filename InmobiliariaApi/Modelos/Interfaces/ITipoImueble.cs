using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface ITipoInmueble
    {
        Task<List<TipoInmuebleData>> GetAllTipoInmueble();
    }
}
