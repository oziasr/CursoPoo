using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Func.virt.over.seal
{
    class CProducto
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcon,Double pPrecioCompra)
        {
            descripcion = pDescripcon;
            precioCompra = pPrecioCompra;
            precioVenta = 0;
        }
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }
        public void MuestraVenta()
        {
            Console.WriteLine($"El precio de {descripcion} es de {precioVenta}");
        }
    }
}
