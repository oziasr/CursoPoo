using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Uso_de_new_en_métodos
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;

        public CProductoImportado(string pDescripcion,double pPrecioCompra,double pImpuesto)
            : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio producto importado");// CON FINES PEDAGÓGICOS
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        public new void MuestraPrecio()
        {
            Console.WriteLine($"El gran producto {descripcion} se vende en {precioVenta} dólares");
        }
    }
}
