using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Sobrecarga_de_métodos___overloading
{
    class CCalculadora
    {
        public int Suma(int a, int b)
        {
            int r = a + b;
            return r;
        }
        public double Suma(double a, double b) //ESTA ES OTRA VERSIÓN DE SUMA ( SOBRECARGA )
        {
            double r = a + b;
            return r;
        }
        public int Suma(int a, int b, int c) //ESTA ES OTRA VERSIÓN DE SUMA ( SOBRECARGA )
        {
            int r = a + b+ c;
            return r;
        }
    }
}
