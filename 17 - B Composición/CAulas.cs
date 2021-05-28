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
            string mensaje = string.Format($"Un aula de {nombreAula} con capacidad para {cantidadAlumnos} alumnos");
            return mensaje;
        }   

    }
}
