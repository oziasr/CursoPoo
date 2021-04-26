using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // PODEMOS HACER CASTING A UNA CLASE EN LA CADENA DE HERENCIA
            // CProductoImportado es un CProducto
            CProducto P1 = new CProductoImportado("Televisor", 3000, 0.15);
            P1.CalculaPrecio();
            Console.WriteLine(P1);
           
            // NO PUEDE INVOCAR LO QUE NO ES COMÚN
            // P1.Mensaje();
            ((CProductoImportado)P1).mensaje();// TYPE CAST

            Console.WriteLine("----------------"); 
            // CProducto es un Object                                  OBJECT
            object P2 = new CProducto("Radio",2000);
            ((CProducto)P2).CalculaPrecio();// TYPE CAST
            Console.WriteLine(((CProducto)P2));// TYPE CAST  

            Console.WriteLine("-----------------");
            // Object no es un CProducto
            // CProducto P3 = new Object(); // NO SE PUEDE

            Console.WriteLine("----- DETECTA------");
            CProducto p4 = new CProducto("Balón", 100);
            Detecta(P1);
            Detecta((CProducto)P2);
            Detecta(p4);
            
            Console.WriteLine($"===============");
            // CASTING  NUMÉRICOS
            int a = 57;
            float b = 5.67f;
            double c = 123.456;
            byte x = 5;

            // DE UN TIPO MENOR A UNA MAYOR NO HACE FALTA EXPLÍCITAMENTE EL CASTING
            a = x;
            Console.WriteLine(a);

            double y = b;
            Console.WriteLine(b);
            // DE UN TIPO MAYOR A UNO MENOR
            // b=c;
            b = (float)c;
            Console.WriteLine(b);
            Console.ReadKey();

        }
        public static void Detecta(CProducto pProducto)
        {
            if (pProducto is CProducto)
            {
                Console.WriteLine($"Es un CProducto");
                pProducto.CalculaPrecio();
                Console.WriteLine(pProducto);
            }
            if (pProducto is CProductoImportado)
            {
                Console.WriteLine($"Es un CProductoImportado");
                pProducto.CalculaPrecio();
                ((CProductoImportado)pProducto).mensaje();
                Console.WriteLine(pProducto);
            }
        }
    }
}
