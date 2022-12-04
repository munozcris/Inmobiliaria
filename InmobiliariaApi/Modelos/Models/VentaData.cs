using System.ComponentModel.DataAnnotations;

namespace Modelos.Models
{
    public class VentaData
    {
        [Key]
        public int id_venta { get; set; }
        public InmuebleData InmuebleData { get; set; }
        public ClienteData ClienteData { get; set; }
        public CondicionData CondicionData { get; set; }
        public FormaPagoData Forma_PagoData { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaVenta { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescVenta { get; set; }


        [Required(ErrorMessage = "Este campo es requerido")]
        public decimal TotalVenta { get; set; }


        [Required(ErrorMessage = "Este campo es requerido")]
        public decimal Total_iva { get; set; }


        [Required(ErrorMessage = "Este campo es requerido")]
        public decimal Total_general { get; set; }
    }
}
