using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum ItemTipos 
    {
        Arma,
        Pocion
    }
    abstract class Item
    {
        string nombre;
        float precio;
        ItemTipos tipos;

        public abstract void Usar();
        public abstract void Curar();
    }
}
