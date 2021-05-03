using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06c
{
    class Program
    {
        static void Main(string[] args)
        {
           

            CEmpleado Juan = new CEmpleado();
            Console.WriteLine($"Dime el sueldo de Juan");
            Juan.SetSueldo(Convert.ToInt32(Console.ReadLine()));
            Juan.GetSueldo();
            Juan.CalculaImpuesto();
            Console.WriteLine($"Dime la contraseña para calcular el impuesto");
            Juan.GetImpuesto(Convert.ToInt32(Console.ReadLine()));
            Juan.Muestra();
            Juan.MuestraLog();
            Console.ReadKey();



        }
    }
}
