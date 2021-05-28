using System;

namespace _16___Agregación_2
{
    class Program
    {
        static void Main(string[] args)
        {// ESTE PROYECTO NO LO HE TERMINADO
            CPropietario uno = new CPropietario("Juan");
            CPropietario dos = new CPropietario("Pedro");
            CEdificio Mangilli = new CEdificio("Castillito", 12, 5); // ESTO SÍ ES UNA INSTANCIA
            CEdificio BerMary = new CEdificio("Altavista", 20, 13);
            uno.AdicionaPropiedad(Mangilli);
            dos.AdicionaPropiedad(BerMary);
            uno.MostrarPropiedad();
            dos.MostrarPropiedad();
            Console.ReadKey();
        }
    }
}
