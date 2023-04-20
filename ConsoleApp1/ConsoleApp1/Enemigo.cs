﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enemigo: NPC
    {
        public float daño;
        int nivel;
        int experiencia;

        List<Item> items;
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
    }
}
