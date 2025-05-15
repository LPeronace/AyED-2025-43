namespace _1_Peronace_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salud = 100, hambre = 50, energia = 70, dia = 0, probabilidad;
            bool salir = false;
            Random rand = new Random();

            do
            {
                Console.WriteLine("Hoy es dia "+dia+",que opción queres elegir?");
                Console.WriteLine("1 para buscar comida");
                Console.WriteLine("2 para dormir");
                Console.WriteLine("3 para explorar la isla");
                Console.WriteLine("4 para ver el estado de tu personaje");
                Console.WriteLine("5 para salir del juego");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        probabilidad = rand.Next(1, 101);
                        Console.WriteLine("Buscaste comida...");
                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("Encontraste comida,pero vos no sabia que esta estaba en mal estado :(  (Salud -15, Energia -15, +20 hambre)");
                            
                            salud -= 15;
                            energia -= 15;
                            hambre += 20;
                        }
                        else
                        {
                            Console.WriteLine("Encontraste comida y en buen estado!!! (+20 hambre,Energia -15) ");
                            
                            hambre += 20;
                            energia -= 15;
                        }
                        if (salud <= 0 || energia <= 0 || hambre <= 0)
                        {
                            Console.WriteLine("Moriste :(");
                           
                            salir = true;
                        }
                            break;

                    case "2":
                        Console.WriteLine("Dormiste tranquilamente...(Energia +30, Hambre -10, +1 dia)");
                        
                        energia += 30;
                        hambre -= 10;
                        dia += 1;
                        
                        if (salud <= 0 || energia <= 0 || hambre <= 0)
                        {
                            Console.WriteLine("Moriste :(");
                            salir = true;
                        }
                        break;

                    case "3":
                        probabilidad = rand.Next(1, 101);
                        Console.WriteLine("Saliste a explorar la isla... (Energia -20, Hambre -15)");

                        energia -= 20;
                        hambre -= 15;
                        
                        if (probabilidad<= 50)
                        {
                            Console.WriteLine("Encontraste una plantita medicinal!!!! (Salud +10)");
                            salud += 10;
                        }
                        
                        if (salud <= 0 || energia <= 0 || hambre <= 0)
                        {
                            Console.WriteLine("Moriste :(");
                            salir = true;
                        }
                        break;
                        
                    case "4":
                        Console.WriteLine("Actualmente las stats son:");
                        Console.WriteLine("tenes " + salud + " de salud, tenes "+ energia+" de energia,"+ " tenes "+hambre+ " de hambre y pasaron "+dia+ " dias");
                        break;

                    case "5": Console.WriteLine("Chauuu");
                        salir = true;
                        break;
                    default:Console.WriteLine("Error, Elegi devuelta");
                        break;
                }
                if (dia>= 7)
                {
                    Console.WriteLine("Sobreviviste, felicidades!! (llevate a Wilson con vos..)");
                    salir = true;
                }

            } while (!salir);
        }
    }
}
