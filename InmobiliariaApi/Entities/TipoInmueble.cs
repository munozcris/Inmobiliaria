using Modelos.Models;

namespace Entities
{
    public class TipoInmueble
    {
        private int id_tipo_inmueble;
        private string Desc_tipo_inmueble;

        public TipoInmueble(TipoInmuebleData inmuebleData)
        {
            this.id_tipo_inmueble = inmuebleData.id_tipo_inmueble;
            this.Desc_tipo_inmueble = inmuebleData.Desc_tipo_inmueble;
        }

        public int Id_Tipo_Inmueble
        {
            get { return id_tipo_inmueble; }
            set { id_tipo_inmueble = value; }
        }

        public string Desc_Tipo_Inmueble
        {
            get { return Desc_tipo_inmueble; }
            set { Desc_tipo_inmueble = value; }
        }
    }
}
