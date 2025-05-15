using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string Tiempo = DateTime.Now.ToString();

            Console.WriteLine("Bienvenido Al Menu Interactivo, Eliga 1 de las 4 opciones que tiene; 1 Para Saludo, 2 Para fecha y hora actual, 3 para averiguar si es año bisiesto y 4 para salir");

            string numero = Console.ReadLine();

            do
            {
                switch (numero)
                {
                    case "1":Console.WriteLine("Holaaa");
                        break;
                    case "2":
                        Console.WriteLine("La fecha y hora actual es:"+Tiempo);
                        break;
                    case "3":
                        Console.WriteLine("En que año estamos?");
                        int año = int.Parse(Console.ReadLine());
                        if (año % 4 == 0)
                        {
                            Console.WriteLine("El año:"+ año+ " es bisiesto!!!");
                        }
                        else
                        {
                            Console.WriteLine("El año:" + año + " no es bisiesto :(");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa, presione alguna tecla porfavo");
                        salir = false;
                        break;
                    default:Console.WriteLine("Erorr");
                        break;
                }
            } while (salir);

            Console.ReadKey();
        }
    }
}
