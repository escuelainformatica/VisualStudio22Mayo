using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    // clase de servicio
    // metodos (o funciones) y no quiero ni campos ni propiedades
    class ProductoServicio
    {
        // el nombre de la funcion por lo general es una accion o verbo.
        public int SumarArreglo(Producto[] arreglo)
        {
            return arreglo[0].Precio + arreglo[1].Precio + arreglo[2].Precio;
        }
        public int SumarListado(List<Producto> listado)
        {
            return listado[0].Precio + listado[1].Precio +  listado[2].Precio;
        }
        public Producto[] CrearArreglo()
        {
            Producto[] arreglo=new Producto[3]; // 3 productos.

            // crear el modelo y asignarle valores a las propiedades
            arreglo[0]=new Producto();
            arreglo[0].NombreProducto="cocacola";
            arreglo[0].Precio=100;
            arreglo[0].Categoria="bebida";
            // usar el constructor
            arreglo[1]=new Producto("Fanta",1000,"bebida");

            // usar la asignacion
            arreglo[2]=new Producto {
                NombreProducto="Sprite"
                ,Precio=2000
                ,Categoria="bebida" 
                };

            return arreglo;
        }
   
        public List<Producto> CrearLista()
        {
            List<Producto> lista=new List<Producto>(); // <-- lo vamos a usar
            lista.Add( new Producto("cocacola",1000,"bebida") );
            lista.Add(new Producto {
                NombreProducto="fanta",Precio=2000,Categoria="bebida"
                });
            lista.Add( new Producto("sprite",3000,"bebida") );
            return lista;
        }

        
    } // aqui termina la clase
}
