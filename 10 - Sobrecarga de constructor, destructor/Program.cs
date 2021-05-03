using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Sobrecarga_de_constructor__destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona per1 = new CPersona();            
            per1.Muestra();
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Salimos del constructor");
            CPersona per2 = new CPersona("",0); // AQUÍ SÓLO INVOCAMOS AL CONSTRUCTOR SOBRECARGADO
            Console.WriteLine("Dime el nombre de la segunda persona");
            per2.Nombre=(Console.ReadLine()); // AQUÍ USAMOS LA PROPIEDAD Nombre DE LA CLASE CPersona
            Console.WriteLine("Dime la edad de la segunda persona");
            per2.Edad = int.Parse(Console.ReadLine());// AQUÍ USAMOS LA PROPIEDAD Edad DE LA CLASE CPersona
            per2.Muestra();
            Console.ReadKey();
        }
       
    }
}
