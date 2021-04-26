using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Uso_de_new_en_métodos
{
    class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion,double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0;
        }
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio producto"); // CON FINES PEDAGÓGICOS
            precioVenta = precioCompra * 1.3;
        }
        public void MuestraPrecio()
        {
            Console.WriteLine($"{descripcion} se vende en {precioVenta}");
        }
    }
}
