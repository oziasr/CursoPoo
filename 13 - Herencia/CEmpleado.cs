using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Herencia
{
    class CEmpleado : CPersona
    {
        private string cargo;
        private double salario;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public void PonerDatos(string pNombre, int pEdad, string pCargo, double pSalario)
        {
            Nombre = pNombre;
            Edad = pEdad;
            cargo = pCargo;
            salario = pSalario;
        }
        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Es el actual {0} y gana {1} dólares mensuales",cargo,salario);
        }
    }
}
