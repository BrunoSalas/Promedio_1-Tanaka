using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Conversador : NPC, MostrarDatos
    {
        List<string> listaTextos = new List<string>();
        public override void Morir()
        {
            vida = 0;
        }
      
        public string Mostrar()
        {
            return $"{nombre},{vida},{listaTextos}";
        }

        public Conversador(string nombre, int vida, List<string> texto) 
        {
            this.nombre = nombre;
            this.vida = vida;
            tipo = Tipos.Conversadores;
            listaTextos = texto;
        }
    }
}
