using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Abstract
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;

        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }
        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio Importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.3;
        }
        public override void MuestraVenta()
        {
            Console.WriteLine($"El gran producto {descripcion} se vende por {precioVenta}");
        }
    }
}
