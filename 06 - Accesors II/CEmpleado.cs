using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Accesors_II
{
    class CEmpleado
    {
        private double impuesto;
        private double sueldo;
        private double sueldoTotal;
        private string log;
        
        public void Muestra()
        {            
            Console.WriteLine($"Sueldo = {sueldo:n0}, Impuesto = {impuesto:n0}\nEl monto a pagar es de {sueldoTotal:n0}");
        }
        // ACCESORS - GETTER Y SETTER
        public void Set_sueldo(double pSueldo)// SETTER
        {
            while (pSueldo < 5000 || pSueldo > 15000)
            {
                LogError("Sueldo incorrecto " + pSueldo.ToString());
                Console.WriteLine($"Sueldo incorrecto, debe estar entre 5.000 y 15.000 dólares");
                Console.WriteLine($"Intente nuevamente");
                pSueldo = Convert.ToDouble(Console.ReadLine());              
            }
                sueldo = pSueldo;
        }

        private void LogError(string pError)
        {
             log += pError + "\r\n";
        }

        public double Get_sueldo(int pPassword)// GETTER
        {
            if (pPassword != 1234)
            {
                LogError("Password incorrecto " + pPassword.ToString());
                return 0.0;
            }
            else
                return sueldo;
        }
        public double Get_impuesto(int pPassword)// GETTER
        {
            while (pPassword != 1234) 
            {
                          
                //if (pPassword != 1234)
                //{
                    LogError("Password incorrecto " + pPassword.ToString());
                    Console.WriteLine("Password inválido");
                    Console.WriteLine("intente nuevamente");
                    pPassword = (Convert.ToInt32(Console.ReadLine()));
                //}
                
            }
            return impuesto;
        }
        // MUTATOR
        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }

        public void MuestraLog()
        {
            Console.WriteLine(log);
        }

        public void CalculaSueldoTotal()
        {
            sueldoTotal = sueldo - impuesto;
        }

    }
}
