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
        protected string nombre;
        protected float precio;
        public ItemTipos tipos;

        public abstract float Usar();
    
    }
    
}
