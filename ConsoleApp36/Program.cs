using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoServicio servicio=new ProductoServicio();


            //   crear un carro de compras.
            Producto[] arreglo=servicio.CrearArreglo();                        
            int total=servicio.SumarArreglo(arreglo);
            Debug.WriteLine("la suma del arreglo es "+total);

            List<Producto> lista=servicio.CrearLista();
            total=servicio.SumarListado(lista);
            Debug.WriteLine("la suma del lista es "+total);

            // LINQ.

            // operacion lambda p => p.Precio
            //                  alias => (donde o un entonces..)
            // total=lista.Sum( p => p.Precio );
            // Debug.WriteLine("la suma del lista es "+total);

        }
    }
}
