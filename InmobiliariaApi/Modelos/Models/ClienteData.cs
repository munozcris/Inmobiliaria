using System.ComponentModel.DataAnnotations;

namespace Modelos.Models
{
    public class ClienteData
    {
        [Key]
        public int id_cliente { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NombreCliente { get; set; }
        [StringLength(255)]
        public string DireccionCliente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string CorreoCliente { get; set; }

        public int TelefonoCliente { get; set; }
    }
}
