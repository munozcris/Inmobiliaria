using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;
using Modelos.Models;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : ControllerBase
    {
        private IInMueble _inmueble;
        private ITipoInmueble _tipo;

        public InmuebleController(IInMueble inmueble)
        {
            _inmueble = inmueble;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inmueble>>> GetAll()
        {
            var inmuebleDataBase = await _inmueble.GetAllInmuebles();
            var listInmueble = new List<Inmueble>();
            if (inmuebleDataBase.Count > 0)
            {
                foreach (var item in inmuebleDataBase)
                {
                    var inmueble = new Inmueble(item);
                    listInmueble.Add(inmueble);
                }
            }
            return Ok(listInmueble);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInmuebleById(int id)
        {
            var inmuebleDataBase = await _inmueble.GetInmueble(id);
            if (inmuebleDataBase == null)
            {
                return NotFound(404);
            }
            else
            {
                var inmueble = new Inmueble(inmuebleDataBase);
                return Ok(inmueble);
            }

        }
        [HttpPost]
        public async Task<IActionResult> PostInmueble(InmuebleData inmueble)
        {
            var inmuebleDataBase = await _inmueble.PostInmueble(inmueble);
            if (inmuebleDataBase == null)
            {
                return BadRequest();
            }
            else
            {
                var aux = new Inmueble(inmuebleDataBase);
                return Ok(aux);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInmueble(int id)
        {
            var inmuebleDataBase = await _inmueble.GetInmueble(id);
            if (inmuebleDataBase == null)
            {
                return NotFound(404);
            }

            var result = await _inmueble.DeleteInmueble(inmuebleDataBase);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInmueble(int id, Inmueble inmueble)
        {
            var inmuebleDataBase = await _inmueble.GetInmueble(id);
            if (inmuebleDataBase == null)
            {
                return NotFound();
            }
            inmuebleDataBase.ubic_inmueble = inmueble.Ubic_Inmueble;
            inmuebleDataBase.desc_inmueble = inmueble.Desc_Inmueble;
            inmuebleDataBase.costo_inmueble = inmueble.Costo_Inmueble;
            //var tipoDataBase = await _tipo.GetTipo(id);
            inmuebleDataBase.Tipo_Inmueble = inmueble.TipoInmueble;

            var result = await _inmueble.UpdateInmueble(inmuebleDataBase);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
