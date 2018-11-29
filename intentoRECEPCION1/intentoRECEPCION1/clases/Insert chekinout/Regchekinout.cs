using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoRECEPCION1.clases.Insert_chekinout
{
    class Regchekinout
    {
        public static int Insert(DatosChek pDatosRes)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Reservaciones (Id_empleado) values ('{0}')",
                    pDatosRes.Id_empleado), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }

    }
}
