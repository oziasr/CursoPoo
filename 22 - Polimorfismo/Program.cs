using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MODELO CONCRETO
            int opcion;
            Console.WriteLine("Elije un animal");
            Console.WriteLine("1- Perro");
            Console.WriteLine("2- Pez");
            opcion = Convert.ToInt16(Console.ReadLine());

            if (opcion == 1)
            {
                CPerro Miperro = new CPerro();
                Console.WriteLine("Cuál es el nombre del perro ?");
                Miperro.Nombre = Console.ReadLine();
                Miperro.Moverse();
            }
            if (opcion == 2)
            {
                CPez Mipez = new CPez();
                Console.WriteLine("Cuál es el nombre del pez ?");
                Mipez.Nombre = Console.ReadLine();
                Mipez.Moverse();
            }
            Console.WriteLine("-----------");
            // MIDELO POLIMÓRFICO
            Console.WriteLine("Elije una mascota");
            Console.WriteLine("1- Perro");
            Console.WriteLine("2- Ave");
            Console.WriteLine("3- Pez");
            Console.WriteLine("4- Culebra");
            opcion = Convert.ToInt16(Console.ReadLine());
            CAnimal Mimascota = new CAnimal();

            if (opcion==1)  Mimascota = new CPerro(); 

            if (opcion == 2)  Mimascota = new CAve(); 

            if (opcion == 3)  Mimascota = new CPez(); 

            if (opcion == 4)  Mimascota = new CCulebra(); 

            Console.WriteLine("Dime el nombre de la mascota");
            Mimascota.Nombre = Console.ReadLine();
            Mimascota.Moverse();
            Console.ReadKey();


        }
    }
}
