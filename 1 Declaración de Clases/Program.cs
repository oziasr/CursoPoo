using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Declaración_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREAMOS UNA INSTANCIA
            CCalculadora calcu1 = new CCalculadora();
            // PEDIMOS LOS DATOS PARA ACCEDER A LOS ATRIBUTOS
            Console.WriteLine("Dame el primer número");
            calcu1.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo número");
            calcu1.b = Convert.ToDouble(Console.ReadLine());
            calcu1.Suma();
            calcu1.Muestra();

            Console.WriteLine("\n---------------------------\n"); /// SEPARADOR
            
            // CREAMOS OTRA INSTANCIA
            CCalculadora calcu2 = new CCalculadora();
            // PEDIMOS LOS DATOS PARA ACCEDER A LOS ATRIBUTOS
            Console.WriteLine("Dame el primer número");
            calcu2.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo número");
            calcu2.b = Convert.ToDouble(Console.ReadLine());
            calcu2.Suma();
            calcu2.Muestra();
            Console.ReadKey();
            // FIJÉMONOS QUE LOS ATRIBUTOS SE GUARDAN DE FORMA INDEPENDIENTE

        }
    }
}
