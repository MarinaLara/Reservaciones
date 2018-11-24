using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoRECEPCION1.clases
{
    class Conexion
    {
        public static SqlConnection ObtnerCOnexion()
        {
            //SqlConnection Conn = new SqlConnection(@"Data Source=192.168.1.65;Initial Catalog=Hotel;User ID=servidor;Password=servidor123");
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-6JE2PCN;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            Conn.Open();
            return Conn;
        }
    }
}
