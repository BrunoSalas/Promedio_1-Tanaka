using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pocion: Item , MostrarDatos
    {
        int capacidad;

        public Pocion(string nombre, float precio, int capacidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.capacidad = capacidad;
            this.tipos = ItemTipos.Pocion;


        }

        public string Mostrar()
        {
            return $"{nombre},{precio} ,{capacidad}"; 
        }

        public override float Usar()
        {
            return capacidad;
        }
    }
}
