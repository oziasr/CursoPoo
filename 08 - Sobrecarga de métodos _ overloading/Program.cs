using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Sobrecarga_de_métodos___overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int rInt; 
            double rDoub;
            CCalculadora Calcu1 = new CCalculadora();
            rInt=Calcu1.Suma(4, 5);
            Console.WriteLine($"El resultado es {rInt}");
            rDoub = Calcu1.Suma(2.5, 3.5);
            Console.WriteLine($"El resultado es {rDoub}");
            rInt = Calcu1.Suma(4, 5, 6);
            Console.WriteLine($"El resultado es {rInt}");
            Console.ReadKey();
                        
        }
    }
}
