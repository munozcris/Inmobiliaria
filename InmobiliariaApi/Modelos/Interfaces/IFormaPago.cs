using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface IFormaPago
    {
        Task<List<FormaPagoData>> GetAllFormaPago();
    }
}
