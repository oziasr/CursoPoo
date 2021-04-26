using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Func.virt.over.seal
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;

        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            :base(pDescripcion,pPrecioCompra)
        {
            impuesto = pImpuesto;
        }
        public override void CalculaPrecio()
        {// SI USAMOS  public sealed override void CalculaPrecio()
         // ENTONCES LA SUGUIENTE CLASE EN LA CADENA DE HERENCIA NO PODRÁ HACER OVERRIDE
            Console.WriteLine("Calcula precio de producto Importado");
            precioVenta = (precioCompra * (1 + impuesto) * 1.3);
        }
    }
}
