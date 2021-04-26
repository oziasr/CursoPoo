using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___El_constructor
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona()// CREAMOS EL MÉTODO CONSTRUCTOR CON EL MISMO NOMBRE DE LA CLASE
        {
            Console.WriteLine("Estamos en el constructor");
            Console.WriteLine("Dime el Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime la edad");
            edad = int.Parse(Console.ReadLine());
            //nombre = "";
            //edad = 0;
        }
        public string Nombre
        {
            set { nombre = value; }
        }
        public int Edad
        {
            set { edad = value; }
        }
        public void Muestra()
        {
            Console.WriteLine($"Hola {nombre}, el próximo año tendrás {edad+1} años");
        }
    }
}
