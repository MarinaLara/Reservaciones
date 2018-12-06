using RECEPCION.clases.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Habitaciones
{
    class Insertacion
    {
        public static int Agregar(DatHabitacion pDatHabitacion)
        {
            int retorno = 0;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Habitaciones (No_cuarto, Tipo_habitacion, Estado_habitacion, Disponibilidad, Precio) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    pDatHabitacion.No_cuarto, pDatHabitacion.Tipo_habitacion, pDatHabitacion.Estado_habitacion, pDatHabitacion.Disponibilidad, pDatHabitacion.Precio), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
