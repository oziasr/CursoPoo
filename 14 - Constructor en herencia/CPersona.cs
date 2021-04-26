using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Constructor_en_herencia
{
    class CPersona
    {
        private int edad;
        private string nombre;

        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor de persona");
            nombre = pNombre;
            edad = pEdad;        
        }
      
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
            
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 18)

                    edad = value;

                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
        }
        public void Muestra()
        {
            Console.WriteLine($"{nombre} tiene {edad} años");
        }
    }

    
}
