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
            Console.Write("el edificio de {0} con {1} apartamentos rentados y {2} disponibles",direccion,ApartamentosRentados,CantidadApartamentos-ApartamentosRentados);
        }
    }
}
