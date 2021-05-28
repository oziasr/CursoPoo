using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //CProducto Miproducto = new CProducto("Carrito", 2500);// NO SE PUEDE CREAR UNA INSTANCIA DE UNA CLASE ABSTRACTA
            CProductoImportado MiprodImp = new CProductoImportado("Carrito", 25000, 0.15);
            MiprodImp.CalculaPrecio();
            MiprodImp.MuestraVenta();
            Console.WriteLine("-------------------");

            CProductoDetenido MiprodDet = new CProductoDetenido("Avioncito", 30000, 0.15, 0.3);
            MiprodDet.CalculaPrecio();
            MiprodDet.MuestraVenta();

            Console.ReadKey();

        }
    }
}
