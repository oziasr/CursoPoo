using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___B_Composición
{
    class CEscuela
    {
        private string nombreEscuela;
        private int numerodeAulas=3;
        public CAulas[] aulas = new CAulas[3];
        //private aulas =new CAulas
        public CEscuela (string pNombre, int pNumeroAulas)
        {
            nombreEscuela = pNombre;
            numerodeAulas = pNumeroAulas;
        }
        public void ColocaAulas()
        {
            int n = 0;
            string nombre = "";
            int cantidad = 0;

            for(n=0;n<aulas.Length;n++)
            {
                Console.WriteLine("Dame el nombre del aula {0}",n+1);
                nombre = Console.ReadLine();
                Console.WriteLine("Dime la capacidad del aula {0}",n+1);
                cantidad = int.Parse(Console.ReadLine());

                aulas[n] = new CAulas(nombre, cantidad);
            }
        }
        public override string ToString()
        {
            string mensaje = "";
            int n = 0;
            mensaje = string.Format($"Bienvenidos a la escuela {nombreEscuela}, la cual tiene:\n");
            for (n=0;n<aulas.Length;n++)
            {
                mensaje += aulas[n].ToString() + "\n";
            }
            return mensaje;
        }
    }
}
