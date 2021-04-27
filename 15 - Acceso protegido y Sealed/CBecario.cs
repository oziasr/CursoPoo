using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Acceso_protegido_y_Sealed
{
    class CBecario : CPersona // NO PUEDE DESCENDER DE LA CLASE CEmpleado PORQUE ESTÁ SELLADA "sealed"
    {
        private int horasBeca;

        public CBecario(string pNombre, int pEdad, int pHoras)
            :base(pNombre, pEdad)
         {
            horasBeca=pHoras;
         }
       
        public int HorasBeca
        {
            get { return horasBeca; }

            set { horasBeca = value; }
        }

        public void MuestraBecario()
        {
            Console.WriteLine("Cantidad de Horas");
        }
    }
}