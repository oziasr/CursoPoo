using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Polimorfismo
{
    class CPerro:CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine($"El perro {nombre} camina");
        }
    }
}
