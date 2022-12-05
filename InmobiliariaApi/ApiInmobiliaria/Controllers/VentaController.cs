using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;
using Modelos.Models;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        IVenta _venta;
        ICondicion _condicion;

        public VentaController(IVenta venta)
        {
            _venta = venta;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetAll()
        {
            var ventaDataBase = await _venta.GetAllVentas();
            var listVentas = new List<Venta>();
            if (ventaDataBase.Count > 0)
            {
                foreach (var item in ventaDataBase)
                {
                    var venta = new Venta(item);
                    listVentas.Add(venta);
                }
            }
            return Ok(listVentas);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVentaById(int id)
        {
            var ventaDataBase = await _venta.GetVenta(id);
            if (ventaDataBase == null)
            {
                return NotFound(404);
            }
            else
            {
                var venta = new Venta(ventaDataBase);
                return Ok(venta);
            }

        }
        [HttpPost]
        public async Task<IActionResult> PostVenta(VentaData venta)
        {
            //Condicion como vendida
            venta.CondicionData = await _condicion.GetCondicionById(2);
            //traer precio desde inmueble
            venta.TotalVenta = venta.InmuebleData.costo_inmueble;
            venta.Total_iva = venta.TotalVenta * (21 / 100);
            venta.Total_general = venta.TotalVenta + venta.Total_iva;
            var ventaDataBase = await _venta.PostVenta(venta);
            if (ventaDataBase == null)
            {
                return BadRequest();
            }
            else
            {
                var aux = new Venta(ventaDataBase);
                return Ok(aux);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            var ventaDataBase = await _venta.GetVenta(id);
            if (ventaDataBase == null)
            {
                return NotFound(404);
            }

            var result = await _venta.DeleteVenta(ventaDataBase);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
