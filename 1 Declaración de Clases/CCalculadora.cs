using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Declaración_de_Clases
{
    class CCalculadora
    {
        // DECLARAMOS LOS ATRIBUTOS
        public double a;
        public double b;
        public double r;

        // DECLARAMOS LOS MÉTODOS
        public void Suma()// ESTE MÉTODO REALIZA UNA ACCIÓN
        {
            r = a + b;
        }
        public void Muestra()// ESTE MÉTODO SÓLO MUESTRA RESULTADOS
        {
            Console.WriteLine("El Resultado de sumar {0} más {1} es {2}", a, b, r);
        }

    }
}
