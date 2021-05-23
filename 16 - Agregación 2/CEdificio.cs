using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Agregación_2
{
    class CEdificio
    {
        // ATRIBUTOS
        private int numEdificio = 0;
        private string direccion;
        private int CantidadApartamentos;
        private int ApartamentosRentados;
        // MÉTODO CONSTRUCTOR
        public CEdificio(string pDireccion, int pCantidad, int pRentados)
        {
            numEdificio++;
            direccion = pDireccion;
            CantidadApartamentos = pCantidad;
            ApartamentosRentados = pRentados;

        }// MÉTODO MUESTRA
        public void Muestra()
        {
            Console.Write($"el edificio {numEdificio} de {direccion} con {ApartamentosRentados} apartamentos rentados y {CantidadApartamentos - ApartamentosRentados} disponibles\r\n");
        }
    }
}
