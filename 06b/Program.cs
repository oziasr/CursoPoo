using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06b
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado Juan = new CEmpleado();
            //Juan.SetSueldo(4000);
            Console.WriteLine($"Cuánto gana Juan ?");
            Juan.SetSueldo(Convert.ToDouble(Console.ReadLine()));
            //
            //Juan.SetSueldo(10000);
            //Juan.GetSueldo(1546);
            Console.WriteLine($"Dime la contraseña");
            Juan.GetSueldo(Convert.ToInt32(Console.ReadLine()));
            //
            //Juan.GetSueldo(123);
            //Juan.Muestra();
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.MuestraLog();
            Console.ReadKey();

        }
    }
}
