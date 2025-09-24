namespace _3_Peronace_7
{
    internal class Program
    {
        static string[] nombre = new string[20];
        static string[] saga = new string[20];
        static int[] fuerza = new int[20];
        static int[] defensa = new int[20];
        static bool[] esheroe = new bool[20];
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {
            int contador = 0;
            string opcion;
            do
            {
                Console.WriteLine("Bienvenido al menu interactivo de Borderlands Multiverse Manager!");
                Console.WriteLine("Que opcion queres usar?:");
                Console.WriteLine("1. Crear personaje");
                Console.WriteLine("2. Mostrar personajes");
                Console.WriteLine("3. Modificar personaje");
                Console.WriteLine("4. Eliminar personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("6. Salir");
                Console.Write("Elija una opción: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        CrearPersonaje(nombre, saga, fuerza, defensa, esheroe,contador);
                        contador++;
                        break;
                    
                    case "2":
                        MostrarPersonaje(nombre, saga, fuerza, defensa, esheroe,contador);
                        break;
                    
                    case "3":
                        ModificarPersonaje(nombre,saga,fuerza,defensa,esheroe,contador);
                        break;
                    
                    case "4":
                        bool a = EliminarPersonaje(nombre, saga, fuerza, defensa, esheroe, contador);
                        if (a)
                        {
                            contador--;
                        }
                        break;
                    
                    case "5":
                        MostrarTodos(nombre, saga, fuerza, defensa, esheroe, contador);
                        break;
                    
                    case "6": Console.WriteLine("Chauuu");
                        break;
                    
                    default: Console.WriteLine("Error, intentelo devuelta porfavor");
                        break;
                }
                Console.Write("Presione enter para seguir:");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != "6");
        }
        static void CrearPersonaje(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esheroe,int contador)
        {
            string b;
            bool check = false;
            if (contador < 20)
            {
                Console.WriteLine("Ok, te voy a pedir unos datitos");
                do
                {
                    check = false;
                    Console.Write("El nombre? ");
                    b = Console.ReadLine();
                    for (int i = 0; i < 20; i++)
                    {
                        if (b == nombre[i])
                        {
                            Console.WriteLine("Ese nombre ya está cargado, elija otro.");
                            check = true;
                            break;
                        }
                    }

                } while (check);

                nombre[contador] = b;

                Console.WriteLine("Y de donde viene?(saga)");
                saga[contador] = Console.ReadLine();

                Console.WriteLine("Su ataque?");
                fuerza[contador] = int.Parse(Console.ReadLine());

                Console.WriteLine("Y su defensa?");
                defensa[contador] = int.Parse(Console.ReadLine());

                Console.WriteLine("Y es heroe o villano?(1 para heroe, 2 para villano)");
                string a = Console.ReadLine();
                if(a == "1")
                {
                    esheroe[contador] = true;
                }
                else if(a == "2")
                {
                    esheroe[contador] = false;
                }
                else
                {
                    Console.WriteLine("Como no sabes ni poner 1 o 2, va directamente para la liga de villanos");
                    esheroe[contador] = false;
                }
            }
            else
            {
                Console.WriteLine("Estamos llenos :(");
            }

        }
        static void MostrarPersonaje(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esheroe,int contador)
        {
            bool check = false;
            Console.Write("Decime el nombre del personaje que queres buscar:");
            string nombreheroe = Console.ReadLine();
            for(int i = 0; i < contador; i++)
            {
                if(nombreheroe == nombre[i])
                {
                    Console.WriteLine("El personaje que buscabas existe!, tiene estos datos");
                    Console.WriteLine("Nombre:" + nombreheroe);
                    Console.WriteLine("Saga:" + saga[i]);
                    Console.WriteLine("Fuerza:" + fuerza[i]);
                    Console.WriteLine("Defensa:" + defensa[i]);
                    if (esheroe[i])
                    {
                        Console.WriteLine("Estado:Heroe");
                    }
                    else
                    {
                        Console.WriteLine("Estado:Villano");
                    }
                    check = true;
                    break;
                }

            }
            if(!check)
            {
                Console.WriteLine("Lamentablemente no existe ningun personaje con ese nombre :(");
            }
        }
        static void ModificarPersonaje(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esheroe,int contador)
        {
            bool check = false;
            Console.Write("Decime el nombre del personaje que queres modificar la defensa o fuerza:");
            string nombreheroe = Console.ReadLine();
            for (int i = 0; i < contador; i++)
            {
                if (nombreheroe == nombre[i])
                {
                    Console.WriteLine("El personaje que buscabas existe!, tiene estos datos");
                    Console.WriteLine("Fuerza:" + fuerza[i]);
                    Console.WriteLine("Defensa:" + defensa[i]);
                    Console.WriteLine("Cual queres cambiar?(1 Para fuerza y 2 para defensa)");
                    string a = Console.ReadLine();
                    if(a == "1")
                    {
                        Console.Write("Ok, el valor antiguo de fuerza ya lo viste, cual va a ser el nuevo valor?:");
                        fuerza[i] = int.Parse(Console.ReadLine());
                    }
                    else if(a == "2")
                    {
                        Console.Write("Ok, el valor antiguo de defensa ya lo viste, cual va a ser el nuevo valor?:");
                        defensa[i] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("No hay ninguna opcion que coincida con esa, volves al menu");
                    }
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Lamentablemente no existe ningun personaje con ese nombre :(");
            }
        }
        static bool EliminarPersonaje(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esheroe, int contador)
        {
            bool check = false;
            Console.Write("Decime el nombre del personaje que queres buscar:");
            string nombreheroe = Console.ReadLine();
            for (int i = 0; i < contador; i++)
            {
                if (nombreheroe == nombre[i])
                {
                    Console.WriteLine("El personaje que buscabas existe!, tiene estos datos(aunque lo vayas a borrar, desalmado)");
                    Console.WriteLine("Nombre:" + nombreheroe);
                    Console.WriteLine("Saga:" + saga[i]);
                    Console.WriteLine("Fuerza:" + fuerza[i]);
                    Console.WriteLine("Defensa:" + defensa[i]);
                    if (esheroe[i])
                    {
                        Console.WriteLine("Estado:Heroe");
                    }
                    else
                    {
                        Console.WriteLine("Estado:Villano");
                    }

                    for (int j = i; j < contador - 1; j++)
                    {
                        nombre[j] = nombre[j + 1];
                        saga[j] = saga[j + 1];
                        fuerza[j] = fuerza[j + 1];
                        defensa[j] = defensa[j + 1];
                        esheroe[j] = esheroe[j + 1];
                    }
                    nombre[contador - 1] = "";
                    saga[contador - 1] = "";
                    fuerza[contador - 1] = 0;
                    defensa[contador - 1] = 0;
                    esheroe[contador - 1] = false;
                    Console.WriteLine("Listo, ya lo borraste, no existe mas, monstruo");
                    check = true;
                    return true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Lamentablemente no existe ningun personaje con ese nombre :(");
                return false;
            }
            return false;
        }
        static void MostrarTodos(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esheroe, int contador)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Aca esta el heroe N°" + (i + 1) + ":");
                    Console.WriteLine("Nombre:" + nombre[i]);
                    Console.WriteLine("Saga:" + saga[i]);
                    Console.WriteLine("Fuerza:" + fuerza[i]);
                    Console.WriteLine("Defensa:" + defensa[i]);
                    if (esheroe[i])
                    {
                        Console.WriteLine("Estado:Heroe");
                    }
                    else
                    {
                        Console.WriteLine("Estado:Villano");
                    }

                }
            }
        }
    }
}
