using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Atributos_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            CCompu compu1 = new CCompu();
            CCompu compu2 = new CCompu("i5", 8, 500);
            CCompu compu3 = new CCompu("i7", 16, 850);
            
            Console.WriteLine("Dime el procesador del equipo 4");
            string a = Console.ReadLine();
            Console.WriteLine("Dime la memoria del equipo 4");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dime el costo del equipo 4 ");
            double c = double.Parse(Console.ReadLine());
            CCompu compu4 = new CCompu(a, b, c);
            Console.WriteLine("Dime la tasa de cambio del día");
            compu1.TipoCambio = double.Parse(Console.ReadLine());// ESTE VALOR VALDRÁ PARA TODOS PORQUE ES ESTÁTICO
            compu1.Muestra();
            Console.WriteLine("--------------------------------------------------");
            compu2.Muestra();
            Console.WriteLine("--------------------------------------------------");
            compu3.Muestra();
            Console.WriteLine("--------------------------------------------------");
            compu4.Muestra();
            Console.ReadKey();
            

        }
    }
}
