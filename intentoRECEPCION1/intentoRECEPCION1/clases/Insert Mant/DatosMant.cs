using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoRECEPCION1.clases.Insert_Mant
{
    class DatosMant
    {
        public String Fecha_solicitud { get; set; }
        public String Solicita { get; set; }
        public int Habitacion { get; set; }
        public String Estado_solicitud { get; set; }        

        public DatosMant() { }

        public DatosMant(String pFecha_solicitud, String pSolicita, int pHabitacion, String pEstado_solicitud)
        {
            this.Fecha_solicitud = pFecha_solicitud;
            this.Solicita = pSolicita;
            this.Habitacion = pHabitacion;
            this.Estado_solicitud = pEstado_solicitud;            
        }
    }
}
