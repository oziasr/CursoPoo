using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Accesors_I
{
    class CEmpleado
    {
        private double impuesto;
        private double sueldo;
        private double impt;

        public void Muestra(double Psueldo, int Pimpt)
        {
            sueldo = Psueldo;
            impt = Pimpt;
            Console.WriteLine($"El sueldo base es de {sueldo:n0} dólares y el impuesto es de {impt:n0}%");
        }
        public void Muestra2()
        {
            Console.WriteLine($"El monto a pagar es de {sueldo-Get_impuesto():n0} dólares");
        }
        // ACCESORS - GETTER Y SETTER 
        public void Set_sueldo(double pSueldo)// SETTER
        {
            sueldo = pSueldo;
        }
        public double Get_sueldo()// GETTER
        {
            return sueldo;
        }
        // MUTATOR
        public double CalculaImpuesto(double pSueldo,int pImpuesto)
        {
            //imp = pImpuesto;
            impuesto = (pSueldo)*(pImpuesto*0.01);
            return impuesto;
        }
        public void Set_impuesto(double pImpuesto)
        {
            impuesto = pImpuesto;
        }
        public double Get_impuesto()// GETTER
        {
            return impuesto;
        }
    }
}
