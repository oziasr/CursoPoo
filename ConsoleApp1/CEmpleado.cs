using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;

        public void Muestra() 
        {
            Console.WriteLine($"El monto a pagar es de {sueldo-impuesto:n0}");
        }
        // MÉTODO GETTER Y SETTER EN UNO SOLO ( NO RECOMENDADO, PERO FUNCIONA )
        public double Sueldo
        {
            get
            {
                return sueldo; // GETTER
            }
            set
            {                
                sueldo = value;             
            }
        }
        public double Impuesto // MÉTODO GETTER 
        { 
            get
            {
                return impuesto;
            }
        }
        public void CalculaImpuesto() // MUTATOR
        {
            impuesto = sueldo * 0.15;
        }
    }
}
