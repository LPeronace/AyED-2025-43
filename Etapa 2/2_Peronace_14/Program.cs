using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pochidex = new string[75, 5];
            bool salir = false;
            do
            {
                Console.WriteLine("Bienvenido a la pochidex, que queres hacer?"+"\n"+"1 para registrar Pochimon"+"\n"+"2 para Asignar Investigador A Pochimon"+"\n"+"3 para actualizar nivel de Pochimon"+"\n"+"4 para marcar Pochimon como investigado"+"\n"+"5 para mostrar informacion de Pochimons"+"\n"+"6 para buscar Pochimons por Tipo"+"\n"+"7 para mostrar Pochimon por investigador"+"\n"+"8 para mostrar Pochimons picados"+"\n"+"9 para salir de la pochidex");
                int opcion = int.Parse(Console.ReadLine());
                Random rand = new Random();

                switch (opcion)
                {
                    case 1:Console.WriteLine("Bienvenido al registro de pochimones,que id tiene tu pochimon?");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Y el nombre?:");
                        pochidex[id, 0] = Console.ReadLine();
                        Console.Write("Y el tipo?(A = Agua, F = Fuego y P = Planta):");
                        pochidex[id, 1] = Console.ReadLine();
                        Console.Write("Y el nivel?:");
                        pochidex[id, 2] = (int.Parse(Console.ReadLine())).ToString(); ;
                        pochidex[id, 3] = "0"; //estado investigacion
                        pochidex[id, 4] = "0"; //Investigador asignado
                        int cantidadencontradas =+ 1;
                        break;
                    case 2:Console.Write("Buenas,Que pochimon queres investigar?, decime el id:");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Y cual es tu codigo de investigador?:");
                        string idi = Console.ReadLine();
                        if(pochidex[id,3] == "0")
                        {
                            Console.WriteLine("Ya estas asignado para investigar ese pochimon, felicidades!!!");
                            pochidex[id, 3] = "1";
                            pochidex[id, 4] = idi; 
                        }
                        else if(pochidex[id,3] == "1")
                        {
                            Console.WriteLine("Ese pochimon ya esta siendo investigado actualmente");
                        }
                        else
                        {
                            Console.WriteLine("Ya investigaron completamente a ese pochimon, intente investigar otro");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Cual es tu codigo de entrenador?");
                        idi = Console.ReadLine();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:Console.WriteLine("Chauuu");
                        salir = true;
                        break;
                    default:
                        break;
                }

            } while (!salir);
            Console.ReadKey();
        }
    }
}
