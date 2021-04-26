using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado juan = new CEmpleado();
            Console.WriteLine($"Cuál es el sueldo base ?");
            juan.Sueldo = Convert.ToDouble(Console.ReadLine());
            juan.CalculaImpuesto();
            Console.WriteLine($"Sueldo = {juan.Sueldo:n0}\nImpuesto = {juan.Impuesto:n0}");
            juan.Muestra();
            Console.ReadKey();
        }
    }
}
