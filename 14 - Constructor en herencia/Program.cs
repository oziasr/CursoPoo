using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Constructor_en_herencia
{
    class Program
    {
        static void Main(string[] args)
        {   
            // CREAMOS UN OBJETO DE LA CLASE PERSONA
            CPersona uno = new CPersona("María", 7);
            uno.Muestra();
            Console.WriteLine("\n--------------");
            //CREAMOS UN OBJETO DE LA CLASE CEMPLEADO
            CEmpleado dos = new CEmpleado("Juan", 5,"Administrador",4500);
            dos.EmpleadoMuestra();
            Console.WriteLine("\n--------------");
            // OTRO OBJETO PIDIENDO LOS DATOS
            Console.WriteLine("Dime el nombre del tercer empleado");
            string a = (Console.ReadLine());
            Console.WriteLine("Dime la edad");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el cargo");
            string c = (Console.ReadLine());
            Console.WriteLine("Dime el sueldo");
            double d = double.Parse(Console.ReadLine());
            CEmpleado tres = new CEmpleado(a,b,c,d);
            tres.EmpleadoMuestra();



            Console.ReadKey();
        }

    }
    
}
