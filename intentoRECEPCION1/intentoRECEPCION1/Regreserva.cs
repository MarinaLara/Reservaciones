using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoRECEPCION1
{
    class Regreserva
    {

        public static int Agregar(DatosRes pDatosRes)
        {
            int retorno = 0;
            using (SqlConnection Conn = CrearReservación.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Reservaciones (Id_empleado, Id_habitacion, Fecha_reservacion, Fecha_entrada, Fecha_salida, Nombre_cliente, Telefono_cliente, Tarjeta_pago, Total) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    pDatosRes.Id_empleado, pDatosRes.Id_habitacion, pDatosRes.Fecha_reservacion, pDatosRes.Fecha_entrada, pDatosRes.Fecha_salida, pDatosRes.Nombre_cliente, pDatosRes.Telefono_cliente, pDatosRes.Tarjeta_pago, pDatosRes.Total), Conn);

                retorno = Comando.ExecuteNonQuery();
                SqlCommand Comando2 = new SqlCommand(string.Format("Insert Into Disponibilidad_hab (Id_habitacion, Fecha_entrada, Fecha_salida, Estado) values ('{0}', '{1}', '{2}', '{3}')",
                    pDatosRes.Id_habitacion, pDatosRes.Fecha_entrada, pDatosRes.Fecha_salida, "No disponible"), Conn);

                retorno = Comando2.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }

    }
}
