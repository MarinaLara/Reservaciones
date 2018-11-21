using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoRECEPCION1.clases.Insert_Mant
{
    class RegSolMant
    {
        public static int Insert_Mantenimiento(DatosMant pDatosMant)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into solicitudes_recepcion_mantenimiento (Fecha_solicitud, Solicita, Habitacion, Estado_solicitud) values ('{0}', '{1}', '{2}', '{3}')",
                    pDatosMant.Fecha_solicitud, pDatosMant.Solicita, pDatosMant.Habitacion, pDatosMant.Estado_solicitud), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
