using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10b
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona persona1 = new CPersona();
            persona1.Muestra();
            Console.WriteLine("\n==================\n");
            CPersona persona2 = new CPersona("José", 25901586, 23);
            persona2.Muestra();
            Console.WriteLine("\n==================\n");
            CPersona persona3 = new CPersona("Michelle");
            persona3.Cedula = 27246768;
            persona3.Edad = 20;
            persona3.Muestra();
            Console.ReadKey();
        }
    }
}
