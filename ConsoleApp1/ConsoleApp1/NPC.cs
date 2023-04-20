using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Tipos
    {
        Enemigos,
        Vendedores,
        Conversadores
    }
    abstract class NPC
    {
        string nombre;
        int vida;
        public Tipos tipo;

        public abstract void Morir();
    }

}
