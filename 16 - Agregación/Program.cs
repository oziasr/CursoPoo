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
            CPropietario dos = new CPropietario("Pedro");
            CEdificio edif1 = new CEdificio("Castillito",12,5); // ESTO SÍ ES UNA INSTANCIA
            CEdificio edif2 = new CEdificio("Altavista", 20, 13);
            uno.AdicionaPropiedad(edif1);
            dos.AdicionaPropiedad(edif2);
            uno.MostrarPropiedad();
            dos.MostrarPropiedad();
            Console.ReadKey();
        }
    }
}
