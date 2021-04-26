using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Agregación
{
    class Program
    {
        static void Main(string[] args)
        {
            CPropietario uno = new CPropietario("Juan");
            CEdificio edif1 = new CEdificio("Castillito",12,5); // ESTO SÍ ES UNA INSTANCIA
            uno.AdicionaPropiedad(edif1);
            uno.MostrarPropiedad();
            Console.ReadKey();
        }
    }
}
