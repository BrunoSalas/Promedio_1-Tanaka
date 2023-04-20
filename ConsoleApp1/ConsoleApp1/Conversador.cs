using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Conversador : NPC,IMostrarDatos
    {
        List<string> listaTextos = new List<string>();
        public override void Morir()
        {
            vida = 0;
        }

        public string MostrarDatos()
        {
            return $"{nombre},{vida},{listaTextos}";
        }

        public Conversador(string nombre, int vida, List<string> texto) 
        {
            this.nombre = nombre;
            this.vida = vida;
            this.tipo = Tipos.Conversadores;
            listaTextos = texto;
        }
    }
}
