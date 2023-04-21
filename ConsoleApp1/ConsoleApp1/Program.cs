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
            List<Enemigo> enemigos = new List<Enemigo>();
            List<Vendedor> vendedores = new List<Vendedor>();
            Arma espada = new Arma("espada", 100.5f, 1);
            Pocion heal = new Pocion("afrodita", 1f, 100);
            items.Add(espada);
            items.Add(heal);

            bool salir = false;
            bool crearNPC = false;
            bool crearArma = false;

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
                Console.WriteLine("--------------------------------------------------");
                string selección = Console.ReadLine();
                Console.WriteLine("--------------");

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
                        Console.WriteLine("");
                        Console.WriteLine($"Jugador {jugador.ObtenerNombre()} creado");
                        Console.WriteLine("--------------------------------------------------");
                        break;

                    case "2":
                        crearNPC = false;
                        while (!crearNPC)
                        {
                            Console.WriteLine("1. Quieres crear un Aldeano?");
                            Console.WriteLine("2. Quieres crear un Enemigo?");
                            Console.WriteLine("3. Quieres crear un Vendedor?");
                            Console.WriteLine("--------------");
                            string NPC = Console.ReadLine();
                            Console.WriteLine("--------------");
                            switch (NPC)
                            {
                                case "1":
                                    Console.WriteLine("Escribe el nombre del Aldeano:");
                                    string nombreAldeano = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe la Vida:");
                                    string vida = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe cuando dialogos tendra:");
                                    string numeroDialogos = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    List<string> listaDialogos = new List<string>();
                                    Console.WriteLine("--------------");
                                    for (int i = 0; i < Int32.Parse(numeroDialogos); i++)
                                    {
                                        string dialogos = Console.ReadLine();
                                        Console.WriteLine("--------------");
                                        listaDialogos.Add(dialogos);
                                    }
                                    Conversador aldeano = new Conversador(nombreAldeano, Int32.Parse(vida), listaDialogos);
                                    Console.WriteLine($"Aldeano {nombreAldeano} creado {vida}");
                                    Console.WriteLine("--------------------------------------------------");
                                    aldeanos.Add(aldeano);
                                    crearNPC = true;
                                    break;

                                case "2":
                                    Console.WriteLine("Escribir el nombre del Enemigo:");
                                    string nombreEnemigo = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribir la cantidad de vida del Enemigo:");
                                    string vidaEnemigo = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribir el daño del Enemigo:");
                                    string dañoEnemigo = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribir el nivel del Enemigo:");
                                    string nivelEnemigo = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribir la experiencia del Enemigo:");
                                    string experienciaEnemigo = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Enemigo ladron = new Enemigo(nombreEnemigo, Int32.Parse(vidaEnemigo), float.Parse(dañoEnemigo), Int32.Parse(nivelEnemigo), Int32.Parse(experienciaEnemigo));
                                    Console.WriteLine("--------------------------------------------------");
                                    aldeanos.Add(ladron);
                                    enemigos.Add(ladron);
                                    crearNPC = true;
                                    break;

                                case "3":
                                    Console.WriteLine("Escribe el nombre del Vendedor");
                                    string nombreVendedor = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe la cantidad de vida");
                                    string vidaVendedor = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe la cantidad de dinero");
                                    string dineroVendedor = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Vendedor buhonero = new Vendedor(nombreVendedor, Int32.Parse(vidaVendedor), float.Parse(dineroVendedor));
                                    Console.WriteLine("--------------------------------------------------");
                                    aldeanos.Add(buhonero);
                                    vendedores.Add(buhonero);
                                    crearNPC = true;
                                    break;

                                default:
                                    Console.WriteLine("Intenta otro número");
                                    Console.WriteLine("--------------------------------------------------");
                                    break;
                            }
                        }
                        break;

                    case "3":
                        crearArma = false;
                        while (!crearArma)
                        {
                            Console.WriteLine("1.Crear Arma");
                            Console.WriteLine("2.Crear Pocion");
                            Console.WriteLine("--------------------------------------------------");
                            string indice = Console.ReadLine();
                            Console.WriteLine("");
                            switch (indice)
                            {
                                case "1":
                                    Console.WriteLine("Escribe Nombre:");
                                    string armaNombre = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe Precio:");
                                    string armaPrecio = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Escribe Daño:");
                                    string armaDaño = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    items.Add(new Arma(armaNombre, float.Parse(armaPrecio), Int32.Parse(armaDaño)));
                                    Console.WriteLine("");
                                    Console.WriteLine("Arma Agregada"); crearArma = true;
                                    break;
                                case "2":
                                    Console.WriteLine("Escribe Nombre:");
                                    string pocionNombre = Console.ReadLine();
                                    Console.WriteLine("Escribe Precio:");
                                    string pocionPrecio = Console.ReadLine();
                                    Console.WriteLine("Escribe Capacidad:");
                                    string pocionCapacidad = Console.ReadLine();
                                    items.Add(new Pocion(pocionNombre, float.Parse(pocionPrecio), Int32.Parse(pocionCapacidad)));
                                    Console.WriteLine("Pocion Agregada"); crearArma = true;
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("--------------");
                        }
                        break;

                    case "4":
                        if (jugadores.Count !=0)
                        {
                            Console.WriteLine("Jugador:");
                            for (int i = 0; i < jugadores.Count; i++)
                            {
                                Console.WriteLine(jugadores[i].Mostrar());
                            }
                            Console.WriteLine("--------------");
                            Console.WriteLine("Items:");
                            Console.WriteLine("");
                            for (int i = 0; i < itemsJugador.Count; i++)
                            {
                                if (itemsJugador[i].tipos == ItemTipos.Arma)
                                {
                                    Arma arma = itemsJugador[i] as Arma;
                                    Console.WriteLine((i + 1) + ". " + arma.Mostrar());
                                    Console.WriteLine("--------------");
                                }
                                else
                                {
                                    Pocion pocion = itemsJugador[i] as Pocion;
                                    Console.WriteLine((i + 1) + ". " + pocion.Mostrar());
                                    Console.WriteLine("--------------");
                                }
                            }

                            Console.WriteLine("--------------");

                        }  
                        else
                        {
                            Console.WriteLine("No hay jugadores suficientes");
                            Console.WriteLine("--------------");
                        }      
                        break;

                    case "5":
                        if(aldeanos.Count != 0)
                        {
                            for (int i = 0; i < aldeanos.Count; i++)
                            {
                                if (aldeanos[i].tipo == Tipos.Enemigos)
                                {
                                    Enemigo enemigo = aldeanos[i] as Enemigo;
                                    Console.WriteLine("Enemigo:" + i + 1);
                                    Console.WriteLine(enemigo.Mostrar());
                                    Console.WriteLine("        ");
                                }
                                else if(aldeanos[i].tipo == Tipos.Conversadores)
                                {
                                    Conversador conversador = aldeanos[i] as Conversador;
                                    Console.WriteLine("Conversador:" + i + 1);
                                    Console.WriteLine(conversador.Mostrar());
                                    Console.WriteLine("  ");
                                    Console.WriteLine("Dialogos:");
                                    Console.WriteLine("  ");
                                    for (int j = 0; j < conversador.listaTextos.Count; j++)
                                    {
                                        Console.WriteLine($"{j+1}. {conversador.listaTextos[j]} ");
                                        Console.WriteLine("        ");
                                    }
                                }
                                else if(aldeanos[i].tipo == Tipos.Vendedores)
                                {
                                    Vendedor vendedor = aldeanos[i] as Vendedor;
                                    Console.WriteLine("Vendedor:" + i + 1);
                                    Console.WriteLine(vendedor.Mostrar());
                                    Console.WriteLine("  ");
                                }
                                Console.WriteLine("--------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay NPCs");
                            Console.WriteLine("--------------------------------------------------");
                        }

                        break;

                    case "6":
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
                        break;

                    case "7":
                        if(aldeanos.Count != 0)
                        {
                            Console.WriteLine("Escoge a que NPC eliminar");
                            string indiceAldeano = Console.ReadLine();
                            aldeanos.RemoveAt(Int32.Parse(indiceAldeano) - 1);
                            Console.WriteLine("Mataron a un inocente");
                            Console.WriteLine("--------------");
                        }
                        else 
                        {
                            Console.WriteLine("No hay NPC");
                            Console.WriteLine("--------------");
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
                                    Console.WriteLine("Arma:" + (i + 1));
                                    Console.WriteLine(arma.Mostrar());
                                }
                                else
                                {
                                    Pocion pocion = items[i] as Pocion;
                                    Console.WriteLine("Pocion:" + (i + 1));
                                    Console.WriteLine(pocion.Mostrar());
                                }
                            }

                            Console.WriteLine("Ingrese número de item a eliminar");
                            string objetosIndice = Console.ReadLine();
                            items.RemoveAt(Int32.Parse(objetosIndice) - 1);
                            Console.WriteLine("Item Eliminado");
                            Console.WriteLine("--------------");

                        }
                        else
                        {

                            Console.WriteLine("No hay items");
                            Console.WriteLine("--------------");

                        }
                        
                        break;

                    case "9":

                        Console.WriteLine("1.Agregar item jugador");
                        Console.WriteLine("2.Agregar item a enemigo");
                        Console.WriteLine("3.Agregar item a vendedor");
                        Console.WriteLine("--------------------------------------------------");
                        string agregarIndice = Console.ReadLine();
                        Console.WriteLine("");

                        switch (agregarIndice)
                        {
                            case "1":
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
                            case "2":
                                if (enemigos.Count != 0)
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

                                    Console.WriteLine("Escribe el número del item a agregar: ");
                                    string indexItem = Console.ReadLine();

                                    for (int i = 0; i < enemigos.Count; i++)
                                    {
                                            Console.WriteLine((i + 1) + ". " + enemigos[i].Mostrar());
                                    }

                                    Console.WriteLine("Escribe el número del enemigo para agregar: ");
                                    string enemigoIndice = Console.ReadLine();
                                    enemigos[Int32.Parse(enemigoIndice) - 1].AgregarItem(items[Int32.Parse(indexItem) - 1]);
                                }
                                else
                                {
                                    Console.WriteLine("No hay enemigos");
                                }
                                break;
                            case "3":
                                if (vendedores.Count != 0)
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

                                    Console.WriteLine("Escribe el número del item a agregar: ");
                                    string indexItem = Console.ReadLine();

                                    for (int i = 0; i < vendedores.Count; i++)
                                    {
                                        Console.WriteLine((i + 1) + ". " + vendedores[i].Mostrar());
                                    }
                                    Console.WriteLine("Escribe el número del vendedor para agregar: ");
                                    string vendedorIndice = Console.ReadLine();
                                    vendedores[Int32.Parse(vendedorIndice) - 1].AgregarItem(items[Int32.Parse(indexItem) - 1]);
                                }
                                else
                                {
                                    Console.WriteLine("No hay vendedores");
                                }

                                break;
                        }
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
