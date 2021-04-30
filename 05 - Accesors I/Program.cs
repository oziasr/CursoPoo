using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Accesors_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double impuesto;
            int impt;
            // CREAMOS OBJETO
            CEmpleado juan = new CEmpleado();
            //juan.sueldo = 100000; // NO SE PUEDE
            Console.WriteLine($"Dime el sueldo de Juan");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Dime de cuánto es el impuesto");
            impt = Convert.ToInt32(Console.ReadLine());
            juan.Muestra(salario,impt);
            juan.Set_sueldo(salario);
            //juan.Set_impuesto(impuesto);
            //juan.Muestra();

            juan.CalculaImpuesto(salario, impt);
            //juan.Get_impuesto();
            //juan.Muestra();
            juan.Muestra2();
            impuesto = juan.Get_impuesto();
            Console.WriteLine($"El impuesto calculado es de {impuesto:n0} dólares");
            Console.ReadKey();
            //{
            //double monto = 0;
            //int n = 0;
            //double impuesto = 0.0;
            //int cantidad = 0;

            ////CEmpleado hombre = new CEmpleado();
            //Console.WriteLine($"Cuántos empleados son");
            //cantidad = Convert.ToInt32(Console.ReadLine());
            //CEmpleado[] cEmpleados = new CEmpleado[cantidad];
            ////CEmpleado [] cEmpleados =new CEmpleado[2];
            //for (n = 0; n < cantidad; n++)
            //{
            //    Console.WriteLine($"Dime el sueldo del empleado {n + 1}");
            //    monto = Convert.ToDouble(Console.ReadLine());
            //    cEmpleados[n].Set_sueldo(monto);
            //    //cEmpleados[n].Set_sueldo(monto);
            //    cEmpleados[n].CalculaImpuesto();
            //    impuesto = cEmpleados[n].Get_impuesto();
            //    cEmpleados[n].Muestra();
            //}
            ////cEmpleados[0].Set_sueldo(10000);
            ////Console.WriteLine(cantidad);
            ////cEmpleados[0].sueldo=5000;
            ////Console.WriteLine(cEmpleados[0].sueldo);
            //Console.ReadKey();
        }
    }
     
}
