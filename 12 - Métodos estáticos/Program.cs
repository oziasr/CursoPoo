using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Métodos_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            // CLASE CON MÉTODO NO ESTÁTICO
            CCalculadora calcu1 = new CCalculadora(6, 3);
            calcu1.Suma();
            Console.WriteLine($"El resultado de la suma es {calcu1.R}");
            calcu1.Resta();
            Console.WriteLine($"El resultado de la resta es {calcu1.R}");
            Console.WriteLine("\n----------------------------------------\n");

            // CLASE CON MÉTODOS ESTÁTICOS
            // CUANDO EL MÉTODO ES STATIC NO HACE FALTA CREAR UNA INSTANCIA
            r = CCalculadoraS.Suma(10, 5);
            Console.WriteLine($"El resultado de la suma es {r}");
            r = CCalculadoraS.Resta(10, 5);
            Console.WriteLine($"El resultado de la resta es {r}");
            Console.WriteLine("\n----------------------------------------\n");

            // USAREMOS UN MÉTODO ESTÁTICO, CREANDO UNA INSTANCIA 
            CCalculadoraS miS = new CCalculadoraS();
            miS.Saludo();
            //miS.Suma();// DA ERROR PORQUE EL MÉTODO ESTÁTICO SÓLO SE PUEDE USAR DIRECTAMENTE SIN INSTANCIAR
            Console.ReadKey();
        }
    }
}
