using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06b
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        private string log;
        private int n;
        private double pagar;
        private int imp;

        public void Muestra()
        {   
           Console.WriteLine($"El suledo es de {sueldo:n0} dólares y el impuesto al {imp}% es {impuesto:n0}\nEl monto a pagar el de {pagar:n0}");
        }
        public void SetSueldo(double pSueldo)
        {
            if (pSueldo < 5000 || pSueldo > 15000)
                logError($"El Sueldo {string.Format("{0:#,0} es inválido", pSueldo)}"); // USO string.Format para los puntos de los miles
            //logError($"Sueldo inválido {pSueldo.ToString()}");
            else
            sueldo = pSueldo;
        }
        public double GetSueldo(int pPassword)
        {
            if (pPassword != 1234)
            {
                logError("La contraseña " + pPassword.ToString()+" es incorrecta" );
                //sueldo = 0;
                //return sueldo;
                return 0;
            }
            else
            {
                Console.WriteLine($"Cuál es el impuesto");
                imp = Convert.ToInt32(Console.ReadLine());
                pagar = sueldo - ((imp * 0.01) * (sueldo));
                return pagar;
            }
        }
        private void logError(string pError)
        {
            n++;
            log+=($"Error {n} {pError}\n");// AQUÍ USO EL + PARA AÑADIR OTRA LÍNEA
        }
        public void MuestraLog()
        {
            Console.WriteLine(log);
        }
        public void CalculaImpuesto()
        {
            impuesto = (imp * 0.01) * sueldo;
        }

    }
}
