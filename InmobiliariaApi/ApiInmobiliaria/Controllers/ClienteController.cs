using Entities;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;
using Modelos.Models;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
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
                return Ok(listCliente);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClienteById(int id)
        {
            var clienteDataBase = await _cliente.GetCliente(id);
            if (clienteDataBase == null)
            {
                return NotFound(404);
            }
            else
            {
                var cli = new Cliente(clienteDataBase);
                return Ok(cli);
            }

        }
        [HttpPost()]
        public async Task<IActionResult> PostCliente(ClienteData cliente)
        {
            var clienteDataBase = await _cliente.PostCliente(cliente);
            if (clienteDataBase == null)
            {
                return BadRequest();
            }
            else
            {
                var cli = new Cliente(clienteDataBase);
                return Ok(cli);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var clienteDataBase = await _cliente.GetCliente(id);
            if (clienteDataBase == null)
            {
                return NotFound(404);
            }

            var result = await _cliente.DeleteCliente(clienteDataBase);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
