using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Polimorfismo
{
    class CCulebra : CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine($"La culebra {nombre} se arrastra");
        }
    }
    
}
