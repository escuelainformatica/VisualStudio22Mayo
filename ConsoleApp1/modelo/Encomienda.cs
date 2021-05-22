using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelo
{
    class Encomienda
    {
        public string NombreCliente {set; get;}
        public int Alto {set; get;}
        public int Ancho {set; get;}
        public int Largo {set; get;}

        // boton derecho -> quick action -> Generate Constructor
        public Encomienda(string nombreCliente, int alto, int ancho, int largo)
        {
            NombreCliente = nombreCliente;
            Alto = alto;
            Ancho = ancho;
            Largo = largo;
        }

        public Encomienda()
        {
        }


        // constructor
        // 2019




    }
}
