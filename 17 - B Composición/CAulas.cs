using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___B_Composición
{
    class CAulas
    {
        private string nombreAula;
        private int cantidadAlumnos;
        

        public CAulas (string pNombre, int pCantidad)
        {
            nombreAula = pNombre;
            cantidadAlumnos = pCantidad;
        }
        public override string ToString()
        {
            string mensaje = string.Format("El aula {0} con {1} alumnos", nombreAula, cantidadAlumnos);
            return mensaje;
        }
        

    }
}
