using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ámbito
{
    class CMiClase
    {
        // ESTOS DATOS SE PUEDER VER EN CUALQUIER LUGAR DE LA CLASE
        // PERO NO FUERA DE ELLA  ( ÁMBITO OBJETO )
        private int b = 10;

        public void Muestra()
        {
            // ÁMBITO LOCAL ( VISIBLE SÓLO DENTRO DE ESTE MÉTODO )
            //int m = 5;
            int b = 7;// SE REFIERE A LA VARIABLE LOCAL DENTRO DEL MÉTODO
            this.b = 17;// SE REFIERE A LA VARIABLE DE LA CLASE ( CAMPO DE CLASE ) (OJO ES AMBITO DE OBJETO )
            

            // PODEMOS USAR LA VARIABLE LOCAL Y TAMBIÉN LA VARIABLE DE OBJETO
            Console.WriteLine($"El valor variable local 'b' es: {b}\nEl valor de la variable de Objeto 'b' es: {this.b}");// THIS SE REFIERE AL CAMPO DE CLASE
            // PERO NO PODEMOS USAR VARIABLES PRIVADAS DE OTRAS CLASES U OBJETOS
            // TAMPOCO PODEMOS USAR VARIABLES QUE ESTÉN DENTRO DE OTROS MÉTODOS O FUNCIONES            
        }
        public void Multiplicador()
        {
            this.b = this.b * 5;
            int b = 10;
            int c = 10;
            int r = b * c;
            //this.b = 8;
            Console.WriteLine($"La variable de la clase es {this.b}"); // SE LE LLAMA VARIABLE DE OBJETO (NO CONFUNDIR CON ÁMBITO DE CLASE)
        }
    }
}
