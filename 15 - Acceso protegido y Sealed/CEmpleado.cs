using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Acceso_protegido_y_Sealed
{
    sealed class CEmpleado : CPersona // CLASE SELLADA, NO SE PUEDE HACER HERENCIA DE ESTA CLASE
    {
        private string cargo;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pCargo, double pSalario)
            :base(pNombre,pEdad)
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
            //Nombre = pNombre;
            //Edad = pEdad;
            nombre = pNombre;// AQUÍ YA PODEMOS USAR DIRECTAMENTE EL ATRIBUTO 
            edad = pEdad;
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
