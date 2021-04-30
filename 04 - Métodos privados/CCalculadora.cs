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
        private double r;

        // DECLARAMOS LOS MÉTODOS
        public void Suma()// ESTE MÉTODO REALIZA UNA ACCIÓN
        {
            r = a + b;
            Muestra();// INVOCACIÓN AL MÉTODO PRIVADO
        }
        private void Muestra()// ESTE MÉTODO SÓLO SE PUEDE INVOCAR DESDE ESTA CLASE
        {
            Console.WriteLine($"El Resultado de sumar {a} más {b} es: {r}");
        }

    }
}
