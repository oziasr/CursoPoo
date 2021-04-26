using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Casting
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
        {
            Console.WriteLine("Calcula precio de Producto Importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        public override string ToString()
        {
            return string.Format($"El gran producto {descripcion} se vende en {precioVenta} !!!!!");

        }
        public void mensaje()
        {
            Console.WriteLine("Soy un producto importado");
        }

    }
}
