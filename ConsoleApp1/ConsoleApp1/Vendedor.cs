using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vendedor : NPC
    {

        float dinero;
        List<Item> items;
        public override void Morir()
        {
            vida = 0;
        }

        public Vendedor(string nombre, int vida, List <Item> items) {
        
            this.nombre= nombre;
            this.vida= vida;
            this.items = items;
            this.tipo = Tipos.Vendedores;

        
        }

    }
}
