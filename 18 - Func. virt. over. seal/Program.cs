using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Func.virt.over.seal
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIÓN VIRTUAL Y OVERRIDE CON SEALED
            // CREAMOS UN PRODUCTO
            CProducto uno = new CProducto("Bicicleta", 20000);
            uno.CalculaPrecio();
            uno.MuestraVenta();
            Console.WriteLine("-------------");

            // CREAMOS UN PRODUCTO_IMPORTADO
            CProductoImportado dos = new CProductoImportado("Carrito", 20000, 0.15);
            dos.CalculaPrecio();
            dos.MuestraVenta();
            Console.WriteLine("-----------------");

            // CREAMOS UN PRODUCTO DETENIDO
            CProductoDetenido tres = new CProductoDetenido("Casita", 20000
                ,0.15, 500);
            tres.CalculaPrecio();
            tres.MuestraVenta();

            Console.ReadKey();




            
        }
        
    }
    
}
