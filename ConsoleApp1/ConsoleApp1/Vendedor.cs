using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vendedor : NPC,MostrarDatos
    {

        float dinero;
        List<Item> items = new List<Item>();

        public Vendedor(string nombre, int vida, float dinero)
        {

            this.nombre = nombre;
            this.vida = vida;
            this.dinero = dinero;
            tipo = Tipos.Vendedores;
        }
        public override void Morir()
        {
            vida = 0;
        }

        public string Mostrar()
        {
            return $"{nombre},{vida},{dinero}";
        }
        
        public void AgregarItem(Item item)
        {
            items.Add(item);
        }
    }
}
