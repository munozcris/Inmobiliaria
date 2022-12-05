using Modelos.Models;

namespace Entities
{
    public class Inmueble
    {
        private int id_inmueble;
        private TipoInmuebleData tipo_inmueble_id;
        private string desc_inmueble;
        private string ubic_inmueble;
        private decimal costo_inmueble;

        public Inmueble(InmuebleData inmuebleData)
        {
            this.id_inmueble = inmuebleData.id_inmueble;
            this.tipo_inmueble_id = inmuebleData.Tipo_Inmueble;
            this.desc_inmueble = inmuebleData.desc_inmueble;
            this.ubic_inmueble = inmuebleData.ubic_inmueble;
            this.costo_inmueble = inmuebleData.costo_inmueble;
        }

        public int Id_Inmueble
        {
            get
            {
                return id_inmueble;
            }
            set
            {
                id_inmueble = value;
            }
        }

        public string Desc_Inmueble
        {
            get { return desc_inmueble; }
            set { desc_inmueble = value; }
        }

        public decimal Costo_Inmueble
        {
            get { return costo_inmueble; }
            set { costo_inmueble = value; }
        }

        public string Ubic_Inmueble
        {
            get { return ubic_inmueble; }
            set { ubic_inmueble = value; }
        }

        public TipoInmuebleData TipoInmueble
        {
            get { return tipo_inmueble_id; }
            set { tipo_inmueble_id = value; }
        }
    }
}
