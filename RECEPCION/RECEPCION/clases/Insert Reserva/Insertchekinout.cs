using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_Reserva
{
    class Insertchekinout
    {
        public static int Agregar(DatosRes pDatosRes)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into chekin_out (Id_reservacion) values ('{0}')",
                    pDatosRes.Id_reservacion), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
