using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enemigo: NPC, MostrarDatos
    {
        public float daño;
        int nivel;
        int experiencia;

        List<Item> items;

        public void AgregarItem(Item item)
        {
            items.Add(item);
        }

        public Enemigo(string nombre, int vida, float daño, int nivel, int experiencia)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.daño = daño;
            this.nivel = nivel;
            this.experiencia = experiencia;

            tipo = Tipos.Enemigos;
        }

        public override void Morir()
        {
            vida = 0;
        }

        public string Mostrar()
        {
            return $"{nombre}, {vida}, {daño}, {nivel}, {experiencia}";
        }
    }
}
