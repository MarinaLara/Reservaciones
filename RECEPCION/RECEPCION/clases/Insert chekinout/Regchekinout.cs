using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_chekinout
{
    class Regchekinout
    {
        public static int Insert(DatosChek pDatosRes)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Chekin_out (Id_reservacion, Cin) values ('{0}', '{1}')",
                    pDatosRes.Id_reservación, pDatosRes.Cin), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }

    }
}
