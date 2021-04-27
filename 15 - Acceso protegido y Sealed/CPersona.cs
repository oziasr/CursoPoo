using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Acceso_protegido_y_Sealed
{
    class CPersona
    {
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor de persona");
            nombre = pNombre;
            edad = pEdad;        
        }
        protected int edad;// ATRIBUTO PROTEJIDO ES VISIBLE SOLO PARA LA CADENA DE HERENCIA
        protected string nombre;

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
            Console.WriteLine("{0} tiene {1} años",nombre,edad);
        }
    }

    
}
