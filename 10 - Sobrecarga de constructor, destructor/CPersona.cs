using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Sobrecarga_de_constructor__destructor
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona()
        {
            Console.WriteLine("Estamos en el constructor");
            Console.WriteLine("Dime el nombre");
            nombre=(Console.ReadLine());
            Console.WriteLine("Dime la edad");
            edad = int.Parse(Console.ReadLine());
        }
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor sobrerecargado");
            nombre = pNombre;
            edad = pEdad;
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
            Console.WriteLine($"El nombre es {nombre} y tiene {edad} años");
        }
        ~CPersona()// ÉSTE ES EL DESTRUCTOR
        {
            Console.WriteLine($"Adiós desde el Destructor");
            nombre  = "";
            edad = 0;
            Console.WriteLine($"El nombre es {nombre} y la edad {edad}");
            Console.ReadKey();
        }

    }
}
