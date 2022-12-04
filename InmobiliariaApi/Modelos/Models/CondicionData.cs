using System.ComponentModel.DataAnnotations;

namespace Modelos.Models
{
    public class CondicionData
    {
        [Key]
        public int id_condicion { get; set; }
        public List<VentaData> Ventas { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string desc_condicion { get; set; }

        public CondicionData()
        {
            Ventas = new List<VentaData>();
        }
    }
}
