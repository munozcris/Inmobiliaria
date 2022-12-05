using Modelos.Models;

namespace Entities
{
    public class FormaPago
    {
        private int id_forma_pago;
        private string desc_forma_pago;

        public FormaPago(FormaPagoData item)
        {
            this.id_forma_pago = item.id_forma_pago;
            this.desc_forma_pago = item.desc_forma_pago;
        }

        public int Id_Forma_Pago
        {
            get { return id_forma_pago; }
            set { id_forma_pago = value; }
        }

        public string Desc_Forma_Pago
        {
            get { return desc_forma_pago; }
            set { desc_forma_pago = value;}
        }
    }
}
