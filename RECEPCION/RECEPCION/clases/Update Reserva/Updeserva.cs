using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Update_Reserva
{
    class Updeserva
    {
        public static int Agregar(Update_Reserva pUpdeserva)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Update Reservaciones set Id_empleado = '{0}', Id_habitacion = '{1}', Fecha_reservacion = '{2}', Fecha_entrada = '{3}', Fecha_salida = '{4}', Nombre_cliente = '{5}', Telefono_cliente = '{6}', Total = '{7}' where Id_reservacion = '{8}'",
                    pUpdeserva.Id_empleado, pUpdeserva.Id_habitacion, pUpdeserva.Fecha_reservacion, pUpdeserva.Fecha_entrada, pUpdeserva.Fecha_salida, pUpdeserva.Nombre_cliente, pUpdeserva.Telefono_cliente, pUpdeserva.Total, pUpdeserva.Id_reservacion), Conn);

                retorno = Comando.ExecuteNonQuery();

                SqlCommand Comando2 = new SqlCommand(string.Format("delete from Disponibilidad_hab where Id_dispo = '{0}';",
                    pUpdeserva.Id_dispo), Conn);

                retorno = Comando2.ExecuteNonQuery();

              SqlCommand Comando3 = new SqlCommand(string.Format("Insert Into Disponibilidad_hab (Id_habitacion, Fecha_entrada, Fecha_salida, Estado) values ('{0}', '{1}', '{2}', '{3}')",
                    pUpdeserva.Id_habitacion, pUpdeserva.Fecha_entrada, pUpdeserva.Fecha_salida, "No disponible"), Conn);

                retorno = Comando3.ExecuteNonQuery();
                Conn.Close();
            }
            return retorno;
        }
    }
}
