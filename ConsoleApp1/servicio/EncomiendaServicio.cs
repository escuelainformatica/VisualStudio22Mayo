﻿using ConsoleApp1.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.servicio
{
    class EncomiendaServicio
    {
        public int CalculoVolumen(Encomienda enc)
        {
            int resultado=0;

            // +, -, /, * = funciones o operaciones binarias, involucra dos valores.
            // <,>,<=,>=, == , !=  = operaciones logicas (binarias)
            // 10+20+30  => 10+20 +30
            // ++, -- = operaciones unitarias.
            // a==b ? c:d  = operacion ternaria.


            //todo = to-do tareas por hacer
            resultado=enc.Alto * enc.Ancho * enc.Largo;

            //todo: falta implementar el codigo
            return resultado;
        }
        public int PrecioEncomienda(Encomienda enco)
        {
            int resultado=0;
            //todo: falta implementar
            return resultado;
        }
    }
}
