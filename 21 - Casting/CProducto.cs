using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Casting
{
    class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;
        
        public CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0;
        }
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de Producto");
            precioVenta = precioCompra * 1.30;
        }
        public override string ToString()
        {
            return string.Format($"{descripcion} cuesta {precioCompra} y se vende en {precioVenta}");

        }
    }
}
