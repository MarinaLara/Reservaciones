using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Habitaciones
{
    class Modhabi
    {
        public Int32 Id_habitacion { get; set; }
        public String No_cuarto { get; set; }
        public String Tipo_habitacion { get; set; }
        public String Estado_habitacion { get; set; }
        public String Disponibilidad { get; set; }
        public String Precio { get; set; }

        public Modhabi() { }

        public Modhabi(Int32 pId_habitacion, String pNo_cuarto, String pTipo_habitacion, String pEstado_habitacion, String pDisponibilidad, String pPrecio)
        {
            this.Id_habitacion = pId_habitacion;
            this.No_cuarto = pNo_cuarto;
            this.Tipo_habitacion = pTipo_habitacion;
            this.Estado_habitacion = pEstado_habitacion;
            this.Disponibilidad = pDisponibilidad;
            this.Precio = pPrecio;
        }
    }
}
