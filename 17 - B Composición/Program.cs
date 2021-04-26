using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___B_Composición
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEscuela = "";
            int numerodeAulas = 0;
            
            //CREAMOS LA ESCUELA
            Console.WriteLine("Dime el nombre de la escuela");
            nombreEscuela = Console.ReadLine();
            Console.Write("Cuántas aulas tiene ?");
            numerodeAulas = Convert.ToInt32(Console.ReadLine());
            //CAulas[] aulas2 = new CAulas[numerodeAulas];
            
            CEscuela uno = new CEscuela(nombreEscuela,numerodeAulas);
            // CREAMOS LOS OBJETOS AULAS
            uno.ColocaAulas();
            Console.WriteLine(uno);
            Console.ReadKey();

        }
    }
}
