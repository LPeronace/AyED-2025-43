using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador1";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool espada = false, salir = false;

            do
            {
                Console.WriteLine("Selecciona una de las opciones;");
                Console.WriteLine("1 para mostrar estado");
                Console.WriteLine("2 para encontrar una espada mágica");
                Console.WriteLine("3 para pelear contra un enemigo");
                Console.WriteLine("4 para comprar una pocion de vida (vale 20 moneditas)");
                Console.WriteLine("5 para salir del juego");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": Console.WriteLine("Tu estado actualmente es:");
                        Console.WriteLine("Tenes " + salud + " de salud");
                        Console.WriteLine("Tenes " + monedas+ " monedas");
                        Console.WriteLine("Derrotaste a " + enemigosDerrotados +" enemigos");
                        if (espada)
                        {
                            Console.WriteLine("Tenes espada");
                        }
                        else
                        {
                            Console.WriteLine("No tenes espada :(");
                        }
                        break;
                    case "2": if (espada)
                        {
                            Console.WriteLine("Ya tenes espada, ambicioso, deja para el resto");
                        }
                        else
                        {
                            Console.WriteLine("Felicidades!!, encontraste la espada magica");
                            espada = true;
                        }
                        break;
                    case "3":
                        if (espada)
                        {
                            Console.WriteLine("Ganaste la pelea, pero te sacaron 10 puntos de vida :(");
                            salud -= 10;
                        }
                        else
                        {
                            Console.WriteLine("Ganaste, pero a que costo (-30 de vida");
                            salud -= 30;
                        }
                        enemigosDerrotados += 1;
                        break;
                    case "4":
                        if (monedas>= 20)
                        {
                            Console.WriteLine("Compraste una pocion de vida(-20 monedas,+20 salud");
                            salud += 20;
                            monedas -= 20;
                        }
                        else
                        {
                            Console.WriteLine("No tenes monedas ja");
                        }
                        break;
                    case "5": Console.WriteLine("Chauuu");
                        salir = true;
                        break;
                }

            } while (!salir);

            Console.ReadKey();
        }
    }
}
