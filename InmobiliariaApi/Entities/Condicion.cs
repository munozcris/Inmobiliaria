using Modelos.Models;

namespace Entities
{
    public class Condicion
    {
        private int id_condicion;
        private List<Venta> ventas = new List<Venta>();
        private string desc_condicion;

        public Condicion(CondicionData condicion)
        {
            id_condicion = condicion.id_condicion;
            desc_condicion=condicion.desc_condicion;
            //ventas = condicion.Ventas;
        }

        public int Id_condicion {
            get { 
                return id_condicion;
            }
            set {
                id_condicion = value;        
            } 
        }
        public List<Venta> Ventas {
            get
            {
                return ventas;
            }
            set
            {
                ventas = value;
            }

        }

        public string DescCondicion {
            get
            {
                return desc_condicion;
            }
            set
            {
                desc_condicion = value;
            }
        }
    }
}
