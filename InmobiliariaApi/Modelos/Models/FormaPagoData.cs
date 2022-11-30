using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Models
{
    public class FormaPagoData
    {
        [Key]
        public int id_forma_pago { get; set; }
        public List<VentaData> Ventas { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string desc_forma_pago { get; set; }
    }
}
