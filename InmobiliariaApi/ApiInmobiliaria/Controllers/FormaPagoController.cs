using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Interfaces;

namespace ApiInmobiliaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagoController : ControllerBase
    {
        private IFormaPago _formaPago;

        public FormaPagoController(IFormaPago formaPago)
        {
            _formaPago = formaPago;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormaPago>>> GetAllFormaPago()
        {
            var formaPagoDataBase = await _formaPago.GetAllFormaPago();
            var listFormasPago = new List<FormaPago>();
            if (formaPagoDataBase.Count > 0)
            {
                foreach (var item in formaPagoDataBase)
                {
                    var pago = new FormaPago(item);
                    listFormasPago.Add(pago);
                }
                return Ok(listFormasPago);
            }
            else
            {
                return Ok(listFormasPago);
            }
        }
    }
}
