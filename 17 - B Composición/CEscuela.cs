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
        private int numerodeAulas = 0;
        private CAulas[] aulas; // AQUÍ ESTÁ LA COMPOSICIÓN
        
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
            aulas = new CAulas[numerodeAulas];
            for (n=0;n<aulas.Length;n++)
            {
                Console.WriteLine($"Dame el nombre del aula {n+1}");
                nombre = Console.ReadLine();
                Console.WriteLine($"Dime la capacidad del aula {n+1}");
                cantidad = int.Parse(Console.ReadLine());
                
                aulas[n] = new CAulas(nombre, cantidad);
            }
        }
        public override string ToString()
        {
            string mensaje = "";
            int n = 0;
            mensaje = string.Format($"Bienvenidos a la escuela {nombreEscuela}, la cual tiene {aulas.Length} aulas:\n");
            for (n=0;n<aulas.Length;n++)
            {
                mensaje += aulas[n].ToString() + "\n";
            }
            return mensaje;
        }
    }
}
