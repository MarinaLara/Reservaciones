using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPCION.clases.Insert_chekinout
{
    class DatosChek
    {
        public int Id_reservación { get; set; }
        public String Cin { get; set; }

        public DatosChek() { }

        public DatosChek(int pId_reservación, String pCin)
        {
            this.Id_reservación = pId_reservación;
            this.Cin = pCin;
        }

    }
}
