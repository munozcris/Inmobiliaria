using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Models
{
    public class InmuebleData
    {
        [Key]
        public int id_inmueble { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public TipoInmuebleData Tipo_Inmueble { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string desc_inmueble { get; set; }
        [StringLength(50)]
        public string ubic_inmueble { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public decimal costo_inmueble { get; set; }
    }
}
