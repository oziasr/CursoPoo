using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Métodos_estáticos
{
    class CCalculadoraS
    {
        public static double Suma(double a, double b)
        {
            return a + b;
        }
        public static double Resta(double a, double b)
        {
            return a - b;
        }
        public void Saludo()
        {
            Console.WriteLine($"Hola desde el método NO estático");
        }
    }
}
