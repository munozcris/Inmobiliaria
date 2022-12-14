using Modelos.Models;

namespace Modelos.Interfaces
{
    public interface ICliente
    {
        Task<List<ClienteData>> GetAllClientes();
        Task<ClienteData> GetCliente(int id);
        Task<ClienteData> PostCliente(ClienteData cliente);
        Task<bool> DeleteCliente(ClienteData cliente);
        Task<bool> UpdateCliente(ClienteData cliente);
    }
}
