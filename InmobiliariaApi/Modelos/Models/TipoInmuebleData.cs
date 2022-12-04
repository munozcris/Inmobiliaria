using System.ComponentModel.DataAnnotations;

namespace Modelos.Models
{
    public class TipoInmuebleData
    {
        [Key]
        public int id_tipo_inmueble { get; set; }
        public List<InmuebleData> Inmuebles { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Desc_tipo_inmueble { get; set; }
    }
}
