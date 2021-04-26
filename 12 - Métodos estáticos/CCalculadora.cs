using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Métodos_estáticos
{
    class CCalculadora
    {
        private double a;
        private double b;
        private double r;

        public CCalculadora(double pA, double pB)
        {
            a = pA;
            b = pB;
        }
        public double R
        {
            get { return r; }
        }
        public void Suma()
        {
            r = a + b;
        }
        public void Resta()
        {
            r = a - b;
        }


    }
}
