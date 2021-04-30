using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Declaración_de_Clases
{
    class CCalculadora
    {
        // DECLARAMOS LOS ATRIBUTOS ( POR AHORA PÚBLICOS, PERO DEBERN SER PRIVADOS )
        public double a;
        public double b;
        private double r;

        // DECLARAMOS LOS MÉTODOS
        public void Suma()// ESTE MÉTODO REALIZA UNA ACCIÓN, PERO POR SER VOID NO DEVUELVE NADA
        {
            r = a + b;
        }
        public void Muestra()// ESTE MÉTODO SÓLO MUESTRA RESULTADOS ( OJO, NO DEVUELVE NADA, SÓLO IMPRIME ALGO )
        {
            Console.WriteLine($"El Resultado de sumar {a} más {b} es {r}");
        }

    }
}
