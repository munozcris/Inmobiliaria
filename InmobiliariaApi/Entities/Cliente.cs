using Modelos.Models;

namespace Entities
{
    public class Cliente
    {
        private int id;
        private string nombreCliente;
        private string direccionCliente;
        private string correoCliente;
        private int telefonoCliente;

        public Cliente() { }
        public Cliente(ClienteData cliente)
        {
            Id = cliente.id_cliente;
            NombreCliente = cliente.NombreCliente;
            DireccionCliente = cliente.DireccionCliente;
            CorreoCliente = cliente.CorreoCliente;
            TelefonoCliente = cliente.TelefonoCliente;
        }


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }
        public string DireccionCliente
        {
            get
            {
                return direccionCliente;
            }
            set
            {
                direccionCliente = value;
            }
        }

        public string CorreoCliente
        {
            get
            {
                return correoCliente;
            }
            set
            {
                correoCliente = value;
            }
        }
        public int TelefonoCliente
        {
            get
            {
                return telefonoCliente;
            }
            set
            {
                telefonoCliente = value;
            }
        }
    }
}
