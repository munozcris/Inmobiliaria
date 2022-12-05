using Modelos.Models;

namespace Entities
{
    public class Venta
    {
        private int id_venta;
        private InmuebleData inmuebleId;
        private ClienteData clienteId;
        private CondicionData condicionId;
        private FormaPagoData forma_pagoId;
        private DateTime fechaVenta;
        private string descVenta;
        private decimal totalVenta;
        private decimal total_iva;
        private decimal total_general;

        public Venta(VentaData ventaData)
        {
            this.id_venta = ventaData.id_venta;
            this.inmuebleId = ventaData.InmuebleData;
            this.clienteId = ventaData.ClienteData;
            this.condicionId = ventaData.CondicionData;
            this.forma_pagoId = ventaData.Forma_PagoData;
            this.fechaVenta = ventaData.FechaVenta;
            this.descVenta = ventaData.DescVenta;
            this.totalVenta = ventaData.TotalVenta;
            this.total_iva = ventaData.Total_iva;
            this.total_general = ventaData.Total_general;
        }

        public int Id_Venta
        {
            get { return this.id_venta; }
            set { this.id_venta = value; }
        }

        public InmuebleData InmuebleId
        {
            get { return this.inmuebleId; }
            set { this.inmuebleId = value; }
        }

        public ClienteData ClienteId
        {
            get { return this.clienteId; }
            set { this.clienteId = value; }
        }

        public CondicionData CondicionId
        {
            get { return this.condicionId; }
            set
            {
                this.condicionId = value;
            }
        }

        public FormaPagoData Forma_PagoId
        {
            get { return this.forma_pagoId; }
            set
            {
                this.forma_pagoId = value;
            }
        }

        public DateTime FechaVenta
        {
            get { return this.FechaVenta; }
            set { this.FechaVenta = value; }
        }
        public string Desc_Venta
        {
            get { return this.descVenta; }
            set { this.descVenta = value; }
        }
        public decimal TotalVenta
        {
            get { return this.totalVenta; }
            set { this.totalVenta = value; }
        }

        public decimal Total_iva
        {
            get { return this.total_iva; }
            set { this.total_iva = value; }
        }

        public decimal Total_General
        {
            get { return this.total_general; }
            set { this.total_general = value; }
        }
    }
}
