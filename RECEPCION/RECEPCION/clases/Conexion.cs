using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases
{
    class Conexion
    {
        public static SqlConnection ObtnerCOnexion()
        {
            //Servidor
            //SqlConnection Conn = new SqlConnection(@"Data Source=WIN-KUP04UJ9IG2;Initial Catalog=Hotel;User ID=servidor;Password=servidor123");
            //David
            //SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-6JE2PCN;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            //Marina
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-UGHMV4GH;Initial Catalog=Hotel;User ID=sa;Password=sasa");

            Conn.Open();
            return Conn;
        }
    }
}
