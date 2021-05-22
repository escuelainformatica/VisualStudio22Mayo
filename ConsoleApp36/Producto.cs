using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    // modelo. 
    // propiedades, y no deberiamos tener funciones.

    class Producto
    {
        // campo (al igual que las variables, deben partir en minuscula)
        // public int campo;
        // propiedad (las propiedades deben partir en mayuscula)
        public string NombreProducto {set; get;}
        public int Precio {set; get;}
        public string Categoria {set; get;}

        // el constructor.
        // es un metodo o funcion que se llama cuando se crea el objeto.
        // el constructor no regresa datos (ni siquiera un void) y debe tener el nombre de la clase.

        public Producto(string nombre,int precio,string categoria)
        {
            NombreProducto=nombre;
            // this = indica el objeto actual (en este caso, la propiedad del objeto)
            this.Precio=precio;
            Categoria=categoria;
        }        
        public Producto()
        {

        }



        // sobrecarga.   un constructor o un metodo con el mismo nombre siempre
        // y cuando tenga diferente numero de argumentos







    }
}
