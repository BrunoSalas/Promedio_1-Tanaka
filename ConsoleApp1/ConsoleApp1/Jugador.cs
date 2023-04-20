using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jugador
    {
        string nombre;
        int experiencia;
        float dinero;
        int nivel;

        public Jugador(string nombre, int experiencia, float dinero, int nivel) 
        {
            this.nombre = nombre;
            this.experiencia = experiencia;
            this.dinero = dinero;
            this.nivel = nivel;
        }
        public int GanarExp(int experiencia)
        {
            return this.experiencia += experiencia;
        }
        public float RestarDinero (float dinero)
        {
            return this.dinero -= dinero;
        }
    }
}
