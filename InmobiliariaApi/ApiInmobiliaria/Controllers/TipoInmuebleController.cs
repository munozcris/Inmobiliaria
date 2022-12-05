using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoInmuebleController : ControllerBase
    {
        private ITipoInmueble _tipo;

        public TipoInmuebleController(ITipoInmueble tipo)
        {
            this._tipo = tipo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoInmueble>>> GetAllTipos()
        {
            var tipoDataBase = await _tipo.GetAllTipoInmueble();
            var listTipos = new List<TipoInmueble>();
            if (tipoDataBase.Count > 0)
            {
                foreach (var item in tipoDataBase)
                {
                    var tipoInm = new TipoInmueble(item);
                    listTipos.Add(tipoInm);
                }
            }
            return Ok(listTipos);
        }
    }
}
