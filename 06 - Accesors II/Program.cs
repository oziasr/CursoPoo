using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Accesors_II
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado juan = new CEmpleado();
            Console.WriteLine("Dime el sueldo base de Juan");           
            juan.Set_sueldo(Convert.ToDouble(Console.ReadLine()));// A DIFERENCIA DEL EJERCICIO 05 AQUÍ NO USAMOS VARIBLES
            Console.WriteLine("Dime la clave para calcular el impuesto");
            juan.Get_impuesto(Convert.ToInt32(Console.ReadLine()));
            juan.CalculaImpuesto();
            Console.WriteLine("Juan García");
            juan.CalculaSueldoTotal();
            juan.Muestra();
            juan.MuestraLog();
            Console.WriteLine("\n---------------\n");

            CEmpleado jose = new CEmpleado();
            Console.WriteLine("Dime el sueldo base de José ");
            jose.Set_sueldo(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Dime la clave para calcular el impuesto");
            jose.Get_impuesto(Convert.ToInt32(Console.ReadLine()));
            jose.CalculaImpuesto();
            Console.WriteLine("José González");
            jose.CalculaSueldoTotal();
            jose.Muestra();
            jose.MuestraLog();
            Console.WriteLine("---------------\n");
            Console.ReadKey();  
        }
    }
}
