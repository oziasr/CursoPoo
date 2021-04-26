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
            CPersona persona2 = new CPersona("José", 25901586, 23);
            persona1.Muestra();
            persona2.Muestra();
            Console.ReadKey();
        }
    }
}
