using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Acceso_protegido_y_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {   
            // CREAMOS UN OBJETO DE LA CLASE PERSONA
            CPersona uno = new CPersona("María", 27);
            uno.Muestra();
            Console.WriteLine("\n--------------");

            //CREAMOS UN OBJETO DE LA CLASE CEMPLEADO
            CEmpleado dos = new CEmpleado("Juan", 45,"Administrador",4500);
            //dos.Edad = 15;// ESTO ES PARA VERIFICAR QUE FUNCIONA LA CONDICIÓN DE MENOR DE EDAD
            dos.EmpleadoMuestra();
            Console.WriteLine("\n--------------");

            //OTRO OBJETO PIDIENDO LOS DATOS
            Console.WriteLine("Dime el nombre del tercer empleado");
            string a = (Console.ReadLine());
            Console.WriteLine("Dime la edad");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el cargo");
            string c = (Console.ReadLine());
            Console.WriteLine("Dime el sueldo");
            double d = double.Parse(Console.ReadLine());
            CEmpleado tres = new CEmpleado(a, b, c, d);
            //tres.Edad = 15; // ESTO ES PARA VERIFICAR QUE FUNCIONA LA CONDICIÓN DE MENOR DE EDAD
            tres.EmpleadoMuestra();
            //tres.Edad = 14;// ESTO ES PARA RESLATAR QUE NO FUNCIONA LA CONDICIÓN DE MENOR DE EDAD
            tres.PonerDatos("Pedro", 35, "Portero", 2500);
            tres.EmpleadoMuestra();

            Console.ReadKey();
        }

    }
    
}
