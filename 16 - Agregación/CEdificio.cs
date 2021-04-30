using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Agregación
{
    class CEdificio
    {   // ATRIBUTOS
        private string direccion;
        private int CantidadApartamentos;
        private int ApartamentosRentados;
        // MÉTODO CONSTRUCTOR
        public CEdificio(string pDireccion,int pCantidad,int pRentados)
        {
            direccion = pDireccion;
            CantidadApartamentos = pCantidad;
            ApartamentosRentados = pRentados;

        }// MÉTODO MUESTRA
        public void Muestra()
        {
            Console.Write($"el edificio de {direccion} con {ApartamentosRentados} apartamentos rentados y {CantidadApartamentos-ApartamentosRentados} disponibles\r\n");
        }
    }
}
