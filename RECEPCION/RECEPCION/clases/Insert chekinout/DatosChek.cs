using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_chekinout
{
    class DatosChek
    {
        public String Id_empleado { get; set; }

        public DatosChek() { }

        public DatosChek(String pId_empleado)
        {
            this.Id_empleado = pId_empleado;
            
        }

    }
}
