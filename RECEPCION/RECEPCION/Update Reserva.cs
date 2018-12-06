using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Update_Reserva
{
    class Update_Reserva
    {
        public String Id_empleado { get; set; }
        public String Id_habitacion { get; set; }
        public String Fecha_reservacion { get; set; }
        public String Fecha_entrada { get; set; }
        public String Fecha_salida { get; set; }
        public String Nombre_cliente { get; set; }
        public String Telefono_cliente { get; set; }
        public String Tarjeta_pago { get; set; }
        public float Total { get; set; }
        public String Id_reservacion { get; set; }
        public String Id_dispo { get; set; }

        public Update_Reserva() { }

        public Update_Reserva(String pId_empleado, String pId_habitacion, String pFecha_reservacion, String pFecha_entrada, String pFecha_salida, String pNombre_cliente, String pTelefono_cliente, String pTarjeta_pago, float pTotal, String pId_reservacion, String pId_dispo)
        {
            this.Id_empleado = pId_empleado;
            this.Id_habitacion = pId_habitacion;
            this.Fecha_reservacion = pFecha_reservacion;
            this.Fecha_entrada = pFecha_entrada;
            this.Fecha_salida = pFecha_salida;
            this.Nombre_cliente = pNombre_cliente;
            this.Telefono_cliente = pTelefono_cliente;
            this.Tarjeta_pago = pTarjeta_pago;
            this.Total = pTotal;
            this.Id_reservacion = pId_reservacion;
            this.Id_dispo = pId_dispo;
        }
    }
}
