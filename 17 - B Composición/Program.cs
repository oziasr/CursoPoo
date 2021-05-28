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
            Console.WriteLine("Cuántas aulas tiene ?");
            numerodeAulas = Convert.ToInt32(Console.ReadLine());
            CEscuela miEscuela = new CEscuela(nombreEscuela,numerodeAulas);
            // CREAMOS LOS OBJETOS AULAS
            miEscuela.ColocaAulas();
            Console.WriteLine(miEscuela);
            miEscuela = null; // AL ELIMINAR ESTA INSTANCIA SE ELIMINAN LAS AULAS CREADAS TAMBIÉN
            Console.ReadKey();
        }
    }
}
