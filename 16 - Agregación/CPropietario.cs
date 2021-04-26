using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Agregación
{
    class CPropietario
    {
        private string nombre;
        private CEdificio propiedad = null;// ** OJO ** NO ES UNA INSTANCIA DE CEdificio  

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
        }
        public void MostrarPropiedad()
        {
            if (propiedad !=null)
            {
                Console.Write($"El señor {nombre} es dueño de ");
                propiedad.Muestra();
            }
            else
                Console.WriteLine($"El señor {nombre} aún no tiene propiedades");

        }
        public void AdicionaPropiedad(CEdificio pEdificio)
        {
            if (pEdificio != null)
                propiedad = pEdificio;
        }
    }
}
