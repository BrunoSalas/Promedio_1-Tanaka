using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jugador : MostrarDatos
    {
        string nombre;
        int experiencia;
        float dinero;
        int nivel;
        List<Item> items;
        public Jugador(string nombre, int experiencia, float dinero, int nivel, List<Item> items) 
        {
            this.nombre = nombre;
            this.experiencia = experiencia;
            this.dinero = dinero;
            this.nivel = nivel;
            this.items = items;
        }
        public int GanarExp(int experiencia)
        {
            return this.experiencia += experiencia;
        }

        public string Mostrar()
        {
            return $"{nombre}, {experiencia}, {dinero}, {nivel}";
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public float RestarDinero (float dinero)
        {
            return this.dinero -= dinero;
        }
    }
}
