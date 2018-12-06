using System;
using RECEPCION.clases.Habitaciones;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Habitaciones
{
    class Updhabi
    {
        public static int Agregar(Modhabi pModhabi)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Update Habitaciones set No_cuarto = '{0}', Tipo_habitacion = '{1}', Estado_habitacion = '{2}', Disponibilidad = '{3}', Precio = '{4}' where Id_habitacion = '{5}'",
                    pModhabi.No_cuarto, pModhabi.Tipo_habitacion, pModhabi.Estado_habitacion, pModhabi.Disponibilidad, pModhabi.Precio, pModhabi.Id_habitacion), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
