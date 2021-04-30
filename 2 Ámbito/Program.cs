using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ámbito
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTA VARIABLE SÓLO ES VISIBLE DENTRO DE ESTE MÉTODO MAIN
            int a = 5;
            a = a * 5;
            Console.WriteLine($"El valor de la variable 'a' del método Main es: {a}");
            // TRATAMOS DE USAR UNA VARIABLE DE LA CLASE "CMiClase" Y NOS DA ERROR PORQUE ES PRIVATED
            //b = 10;// nos marca error

            // PROCEDEMOS A INSTANCIAR
            CMiClase objeto = new CMiClase();
            objeto.Muestra();
            objeto.Multiplicador();
            Console.ReadKey();
        }
    }
}
