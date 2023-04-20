using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemsJugador = new List<Item>();
            List<Item> items = new List<Item>();
            List<NPC> aldeanos = new List<NPC>();
            Arma espada = new Arma("espada", 100.5f, 1);
            Pocion heal = new Pocion("afrodita", 1f, 100);
            items.Add(espada);
            items.Add(heal);
            while (true)
            {
                Console.WriteLine("1.Crear Jugador");
                Console.WriteLine("2.Crear Aldeano");
                Console.WriteLine("3.Crear un Item");
                Console.WriteLine("4.Datos del jugador");
                Console.WriteLine("5.Datos de los NPCS");
                Console.WriteLine("6.Datos de los Items");
                Console.WriteLine("7.Eliminar un NPC");
                Console.WriteLine("8.Eliminar un Item");
                Console.WriteLine("9.Salir del programa");
                string selección = Console.ReadLine();

                switch (selección)
                {
                    case "1":
                        Console.WriteLine("Escribe el nombre del jugador:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escribe la experiencia:");
                        string experiencia = Console.ReadLine();
                        Console.WriteLine("Escribe el dinero:");
                        string dinero = Console.ReadLine();
                        Console.WriteLine("Escribe el nivel:");
                        string nivel = Console.ReadLine();
                        Jugador jugador = new Jugador(nombre, Int32.Parse(experiencia), float.Parse(dinero), Int32.Parse(nivel), itemsJugador);
                        Console.WriteLine($"Jugador {jugador.ObtenerNombre()} creado");
                        break;

                    case "2":
                        Console.WriteLine("Escribe el nombre del Aldeano:");
                        string nombreAldeano = Console.ReadLine();
                        Console.WriteLine("Escribe la Vida:");
                        string vida = Console.ReadLine();
                        Console.WriteLine("Escribe cuando dialogos tendra:");
                        string numeroDialogos = Console.ReadLine();
                        List<string> listaDialogos = new List<string>();
                        for (int i = 0; i < Int32.Parse(numeroDialogos); i++)
                        {
                            string dialogos = Console.ReadLine();
                            listaDialogos.Add(dialogos);
                        }
                        Conversador aldeano = new Conversador(nombreAldeano, Int32.Parse(vida), listaDialogos);
                        Console.WriteLine($"Aldeano {nombreAldeano} creado {vida}");
                        aldeanos.Add(aldeano);
                        break;

                    case "3":
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i].tipos== ItemTipos.Arma)
                            {
                                Arma arma = items[i] as Arma;
                                Console.WriteLine((i+1) + ". " + arma.Mostrar());
                            }
                            else
                            {
                                Pocion pocion = items[i] as Pocion;
                                Console.WriteLine((i+1) + ". " + pocion.Mostrar());
                            }
                        }
                        string index = Console.ReadLine();
                        itemsJugador.Add(items[Int32.Parse (index)-1]);
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "8":
                        break;

                    case "9":
                        break;

                    default:
                        Console.WriteLine("Intenta otro número");
                        break;
                }

                Console.ReadLine();
            }

        }
    }
}
