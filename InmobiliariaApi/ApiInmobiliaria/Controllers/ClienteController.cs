using Entities;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ICliente _cliente;

        public ClienteController(ICliente Icliente)
        {
            _cliente = Icliente;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAll()
        {
            var clienteDataBase = await _cliente.GetAllClientes();
            var listCliente = new List<Cliente>();
            if (clienteDataBase.Count > 0)
            {
                foreach (var item in clienteDataBase)
                {
                    var cli = new Cliente(item);
                    listCliente.Add(cli);
                }
                return Ok(listCliente);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}
