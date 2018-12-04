using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_Sol_RH
{
    class DatosSolRH
    {
        public int Id_reservacion { get; set; }
        public String Fecha_solicitud { get; set; }
        public int Habitacion { get; set; }
        public int Devolucion { get; set; }
        public String Estado_solicitud { get; set; }

        public DatosSolRH() { }

        public DatosSolRH(int pId_reservacion, String pFecha_solicitud, int pHabitacion, int pDevolucion, String pEstado_solicitud) 
        {
            this.Id_reservacion = pId_reservacion;
            this.Fecha_solicitud = pFecha_solicitud;
            this.Habitacion = pHabitacion;
            this.Devolucion = pDevolucion;
            this.Estado_solicitud = pEstado_solicitud;
        }
    }
}
