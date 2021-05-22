using ConsoleApp1.modelo;
using ConsoleApp1.servicio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EncomiendaServicio srv=new EncomiendaServicio();
            Encomienda encomienda=new Encomienda("john doe",2,2,2);

            
            Debug.WriteLine("el volumen es "+ srv.CalculoVolumen(encomienda) );

            Debug.WriteLine("el precio del envio es "+ srv.PrecioEnvio(encomienda,20) );

           // Console.WriteLine("el precio del envio es "+ srv.PrecioEnvio(encomienda,40) );

        }
    }
}
