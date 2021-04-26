using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado uno = new CEmpleado();  // OPCIÓN 1
            uno.PonerDatos("Juan", 47, "Contador", 4000); 
            uno.EmpleadoMuestra();

            Console.WriteLine("\n---------------------\n");

            CEmpleado dos = new CEmpleado(); // OPCIÓN 2
            Console.WriteLine("Dime el nombre del segundo empeado");
            string a = (Console.ReadLine());
            Console.WriteLine($"Dime la edad de {a}");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dime el cargo de {a}");
            string c = (Console.ReadLine());
            Console.WriteLine($"Dime cuánto gana {a}");
            double d =Convert.ToDouble(Console.ReadLine());
            dos.PonerDatos(a, b, c, d);
            Console.WriteLine("\n---------------------\n");
            dos.EmpleadoMuestra();

            Console.WriteLine("\n---------------------\n");

            CEmpleado tres = new CEmpleado(); // OPCIÓN 3
            tres.Nombre = "Pedro";
            tres.Edad = 35;
            tres.Cargo = "Portero";
            tres.Salario = 2500;
            tres.EmpleadoMuestra();


            Console.ReadKey();
        }
    }
}
