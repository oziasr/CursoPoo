using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Abstract
{
    class CProductoDetenido:CProducto
    {
        private double multa;
        private double impuesto;

        public CProductoDetenido(string pDescripcion, double pPrecioCompra, double pImpuesto, double pMulta)
            :base(pDescripcion,pPrecioCompra)
        {
            multa = pMulta;
            impuesto = pImpuesto;
        }
        public override void CalculaPrecio()
        {
            Console.WriteLine("Consulta precio detenido");
            precioVenta = (precioCompra * (1 + impuesto) * 1.30) + multa;
        }
        public override void MuestraVenta()
        {
            Console.WriteLine($"El producto en aduana {descripcion} cuesta {precioVenta}");
        }
    }
}
