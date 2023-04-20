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
            List<Jugador> jugadores = new List<Jugador>();
            Arma espada = new Arma("espada", 100.5f, 1);
            Pocion heal = new Pocion("afrodita", 1f, 100);
            items.Add(espada);
            items.Add(heal);

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1.Crear Jugador");
                Console.WriteLine("2.Crear NPC");
                Console.WriteLine("3.Crear un Item");
                Console.WriteLine("4.Datos del jugador");
                Console.WriteLine("5.Datos de los NPCS");
                Console.WriteLine("6.Datos de los Items");
                Console.WriteLine("7.Eliminar un NPC");
                Console.WriteLine("8.Eliminar un Item");
                Console.WriteLine("9.Agregar Item");
                Console.WriteLine("10.Salir del programa");
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
                        if (jugadores.Count != 1)
                        {
                           jugadores.Add(jugador);

                        }
                        else
                        {
                            jugadores[0]=jugador;
                        }
                        Console.WriteLine($"Jugador {jugador.ObtenerNombre()} creado");
                        break;

                    case "2":
                        Console.WriteLine("1. Quieres crear un Aldeano?");
                        Console.WriteLine("2. Quieres crear un Enemigo?");
                        Console.WriteLine("3. Quieres crear un Vendedor?");
                        string NPC = Console.ReadLine();
                        switch (NPC)
                        {
                            case "1":
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

                            case "2":
                                break;

                            case "3":
                                Console.WriteLine("Escribe el nombre del Vendedor");
                                string nombreVendedor= Console.ReadLine();
                                Console.WriteLine("Escribe la cantidad de vida");
                                string vidaVendedor = Console.ReadLine();
                                Console.WriteLine("Escribe la cantidad de dinero");
                                string dineroVendedor = Console.ReadLine();
                                Vendedor buhonero = new Vendedor(nombreVendedor, Int32.Parse(vidaVendedor),float.Parse(dineroVendedor));
                                break;

                            default:
                                Console.WriteLine("Intenta otro número");
                                break;
                        }
                        
                        break;

                    case "3":
                        Console.WriteLine("1.Crear Arma");
                        Console.WriteLine("2.Crear Pocion");
                        string indice = Console.ReadLine();
                        switch (indice)
                        {
                            case "1":
                                Console.WriteLine("Escribe Nombre:");
                                string armaNombre = Console.ReadLine();
                                Console.WriteLine("Escribe Precio:");
                                string armaPrecio = Console.ReadLine();
                                Console.WriteLine("Escribe Daño:");
                                string armaDaño = Console.ReadLine();
                                items.Add(new Arma(armaNombre, float.Parse (armaPrecio), Int32.Parse (armaDaño)));
                                Console.WriteLine("Arma Agregada");
                                break;
                            case "2":
                                Console.WriteLine("Escribe Nombre:");
                                string pocionNombre = Console.ReadLine();
                                Console.WriteLine("Escribe Precio:");
                                string pocionPrecio = Console.ReadLine();
                                Console.WriteLine("Escribe Capacidad:");
                                string pocionCapacidad = Console.ReadLine();
                                items.Add(new Pocion(pocionNombre, float.Parse(pocionPrecio), Int32.Parse(pocionCapacidad)));
                                Console.WriteLine("Pocion Agregada");
                                break;
                            default:
                                break;
                        }
                        break;

                    case "4":
                        if (jugadores.Count !=0)
                        {
                            for (int i = 0; i < jugadores.Count; i++)
                            {
                                Console.WriteLine(jugadores[i].Mostrar());
                            }
                            Console.WriteLine("Items:");
                            for (int i = 0; i < itemsJugador.Count; i++)
                            {
                                if (itemsJugador[i].tipos == ItemTipos.Arma)
                                {
                                    Arma arma = itemsJugador[i] as Arma;
                                    Console.WriteLine((i + 1) + ". " + arma.Mostrar());
                                }
                                else
                                {
                                    Pocion pocion = itemsJugador[i] as Pocion;
                                    Console.WriteLine((i + 1) + ". " + pocion.Mostrar());
                                }
                            }
                                                        
                        }  else
                        {
                            Console.WriteLine("No hay jugadores suficientes");
                        }                                   
                        
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        if(aldeanos.Count != 0)
                        {
                            Console.WriteLine("Escoge a que NPC eliminar");
                            string indiceAldeano = Console.ReadLine();
                            aldeanos.RemoveAt(Int32.Parse(indiceAldeano) - 1);
                            Console.WriteLine("Mataron a un inocente");
                        }
                        else 
                        {
                            Console.WriteLine("No hay NPC");
                        }
                        break;

                    case "8":
                        if(items.Count != 0)
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (items[i].tipos == ItemTipos.Arma)
                                {
                                    Arma arma = items[i] as Arma;
                                    Console.WriteLine((i + 1) + ". " + arma.Mostrar());
                                }
                                else
                                {
                                    Pocion pocion = items[i] as Pocion;
                                    Console.WriteLine((i + 1) + ". " + pocion.Mostrar());
                                }
                            }

                            Console.WriteLine("Ingrese número de item a eliminar");
                            string objetosIndice = Console.ReadLine();
                            items.RemoveAt(Int32.Parse(objetosIndice) - 1);
                            Console.WriteLine("Item Eliminado");

                        }
                        else
                        {

                            Console.WriteLine("No hay items");

                        }
                        
                        break;

                    case "9":
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i].tipos == ItemTipos.Arma)
                            {
                                Arma arma = items[i] as Arma;
                                Console.WriteLine((i + 1) + ". " + arma.Mostrar());
                            }
                            else
                            {
                                Pocion pocion = items[i] as Pocion;
                                Console.WriteLine((i + 1) + ". " + pocion.Mostrar());
                            }
                        }
                        string index = Console.ReadLine();
                        itemsJugador.Add(items[Int32.Parse(index) - 1]);
                        break;

                    case "10":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Intenta otro número");
                        break;
                }

            }

        }
    }
}
