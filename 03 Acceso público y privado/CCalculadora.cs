using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Acceso_público_y_privado
{
    class CCalculadora
    {
        // DECLARAMOS LOS ATRIBUTOS
        public double a;
        public double b;
        private double r;// ÉSTE ATRIBUTO ES PRIVADO

        // DECLARAMOS LOS MÉTODOS
        public void Suma()// ESTE MÉTODO REALIZA UNA ACCIÓN
        {
            r = a + b;
        }
        public void Muestra()// ESTE MÉTODO SÓLO MUESTRA RESULTADOS
        {
            Console.WriteLine($"El Resultado de sumar {a} más {b} es {r}");
        }
    }
}
