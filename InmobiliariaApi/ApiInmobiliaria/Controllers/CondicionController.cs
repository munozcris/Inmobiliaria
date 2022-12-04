using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionController : ControllerBase
    {
        private ICondicion _condicion;

        public CondicionController(ICondicion condicion)
        {
            _condicion = condicion;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condicion>>> GetAllCondicion()
        {
            var condicionDataBase = await _condicion.GetAllCondicion();
            var listCondicion = new List<Condicion>();
            if (condicionDataBase.Count > 0)
            {
                foreach (var item in condicionDataBase)
                {
                    var con = new Condicion(item);
                    listCondicion.Add(con);
                }
                return Ok(listCondicion);
            }
            else
            {
                return Ok(listCondicion);
            }
        }
    }
}
