using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Constructor_en_herencia
{
    class CEmpleado : CPersona
    {
        private string cargo;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pCargo, double pSalario)
            : base(pNombre, pEdad)
        {
            Console.WriteLine("Estamos en el constructor de empleado");
            cargo = pCargo;
            salario = pSalario;
        }
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
            Console.WriteLine($"Es el actual {cargo} y gana {salario:n0} dólares mensuales");
        }
    }
}
