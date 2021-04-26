using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06c
{
    class CEmpleado
    {
       private int sueldo = 0;
       private double impuesto = 0;
        private string log;
       
        public void SetSueldo(int pSueldo)
        {
            sueldo = pSueldo;
        }

        public int GetSueldo()
        {
            return sueldo;
        }
        public double GetImpuesto(int pPassword)
        {
            
            while (pPassword != 1234)
            {
                Console.WriteLine("Contraseña incorrecta !");
                LogError("Contraseña incorrecta " + pPassword.ToString());
                Console.WriteLine($"Vuelva a intentar");
                //return impuesto = 0;
            }
            
                return impuesto;
        }

        private void LogError (string pLogError)
        {   
            log += pLogError+"\r\n"; 
        }

        public double CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
            return impuesto;
        }

        public void Muestra()
        {
            Console.WriteLine($"El sueldo es de {sueldo:N0} menos el impuesto de {impuesto:N0}\r\nEl monto a pagar es de {sueldo-impuesto:N0}");
        }

        public void MuestraLog()
        {
            Console.WriteLine(log);

        }

    }
}
