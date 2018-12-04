using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_Sol_RH
{
    class RegSolRH
    {
        public static int InsSolRH(DatosSolRH pDatosSolRH)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("insert into solicitudes_recepcion_recursoshumanos (Id_reservacion, Fecha_solicitud, Habitacion, Devolucion, Estado_solicitud) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    pDatosSolRH.Id_reservacion, pDatosSolRH.Fecha_solicitud, pDatosSolRH.Habitacion, pDatosSolRH.Devolucion, pDatosSolRH.Estado_solicitud), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
