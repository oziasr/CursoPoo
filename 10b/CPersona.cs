using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10b
{
    class CPersona
    {
        private string nombre;
        private int cedula;
        private int edad;

        public CPersona()
        {
            Console.WriteLine("Estamos en el constructor");
            Console.WriteLine("Dime el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime el número de cédula");
            cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime la edad");
            edad = Convert.ToInt16(Console.ReadLine());
        }
        public CPersona(string Pnombre,int Pcedula,int Pedad)
        {
            Console.WriteLine("Estamos en el constructor sobrerecargado");
            nombre = Pnombre;
            cedula = Pcedula;
            edad = Pedad;
        }
        public CPersona(string Pnombre)
        {
            Console.WriteLine("Estamos en el constructor sobrerecargado 2");
            nombre = Pnombre;
        }

        // PROPIEDADES
        public string Nombre
        {
            set { nombre = value; }
        }
        public int Cedula
        {
            set { cedula = value; }
        }
        public int Edad
        {
            set { edad = value; }
        }
        public void Muestra()
        {
            Console.WriteLine($"El nombre es {nombre}, el número de cédula es {cedula:n0} y tiene {edad} años");
        }

    }
}
