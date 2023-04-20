using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arma : Item, MostrarDatos
    {
        int daño;

        public Arma(string nombre, float precio, int daño)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.daño = daño;
            this.tipos = ItemTipos.Arma;
        }

        public string Mostrar()
        {
            return $"{nombre}, {precio}, {daño}";
        }

        public override float Usar()
        {
            return daño;
        }
    }
}
