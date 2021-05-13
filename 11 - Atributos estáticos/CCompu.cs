using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Atributos_estáticos
{
    class CCompu
    {
        private static double tipoCambio;// STATIC HACE QUE TENGA NIVEL DE CLASE
        // LO CUAL HACE QUE CAMBIE EL VALOR PARA TODOS LOS OBJETOS QUE LO UTILICEN
        private string procesador = "";
        private int memoria;
        private double costo;

        public CCompu()
       {
            procesador = "i3";
            memoria = 4;
            costo = 250;
       }
        public CCompu(string pProcesador, int pMemoria, double pCosto)
        {
            procesador = pProcesador;
            memoria = pMemoria;
            costo = pCosto;
        }
        public double TipoCambio // ESTO ES UNA PROPIEDAD
        {
            set { tipoCambio = value; }
        }
        public void Muestra()
        {
            Console.WriteLine($"Computadora con procesador {procesador} y {memoria}MB de Ram ");
            Console.WriteLine($"Tiene un costo de {costo:n0} dólares");
            Console.WriteLine($"A una tasa de cambio de {tipoCambio:n0} serían unos {costo * tipoCambio:n0} bolívares");
        }
    }  
}
