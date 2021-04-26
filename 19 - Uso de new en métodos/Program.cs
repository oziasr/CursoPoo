using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Uso_de_new_en_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // USO DE NEW EN MÉTODOS
            // NOS PERMITE PONER CÓDIGO PROPIO A MÉTODOS NO VIRTUALES
            // PERO PERDEMOS EL POLILMORFISMO
            CProductoImportado miProducto = new CProductoImportado("Motocicleta", 4500, 0.15);
            miProducto.CalculaPrecio();
            miProducto.MuestraPrecio();
            Console.WriteLine($"---------");

            CProducto miProducto_2 = new CProducto("Carrito", 50000);
            miProducto_2.CalculaPrecio();
            miProducto_2.MuestraPrecio();
            Console.WriteLine($"---------");

            CProducto miproducto_3 = new CProductoImportado("Nevera",50000, 0.2);
            miproducto_3.CalculaPrecio();
            miproducto_3.MuestraPrecio();
            Console.WriteLine($"---------");
            Console.ReadKey();

        }
    }
}
