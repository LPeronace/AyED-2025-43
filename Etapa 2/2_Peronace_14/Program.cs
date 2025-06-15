using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2_Peronace_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pochidex = new string[75,5];
            bool salir = false;
            int encontrado = 0;
            int nombre = 0;
            int tipo = 1;
            int nivel = 2;
            int estado = 3;
            int investigador = 4;
            int p = 0,z = 0;
            string idi;
            Random random = new Random();
            do
            {
                Console.WriteLine("Bienvenido a la pochidex, que queres hacer?" + "\n" + "Cantidad encontrada:"+(encontrado) +"/75"  +"\n" +"1 para registrar Pochimon" + "\n" + "2 para Asignar Investigador A Pochimon" + "\n" + "3 para actualizar nivel de Pochimon" + "\n" + "4 para marcar Pochimon como investigado" + "\n" + "5 para mostrar informacion de Pochimons" + "\n" + "6 para buscar Pochimons por Tipo" + "\n" + "7 para mostrar Pochimon por investigador" + "\n" + "8 para mostrar Pochimons picados" + "\n" + "9 para salir de la pochidex");
                int opcion = int.Parse(Console.ReadLine());
                Random rand = new Random();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Y cual es el nombre?:");
                        pochidex[encontrado, nombre] = Console.ReadLine();

                        Console.Write("Y el tipo?(A = Agua, F = Fuego y P = Planta):");
                        pochidex[encontrado, tipo] = Console.ReadLine();

                        Console.Write("Y el nivel?:");
                        pochidex[encontrado, nivel] = (int.Parse(Console.ReadLine())).ToString(); ;

                        pochidex[encontrado, estado] = "0";

                        pochidex[encontrado, investigador] = "0";

                        encontrado += 1;
                        break;
                    case 2:
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, estado] == "0")
                            {
                                Console.WriteLine("El Pokemon "+ "con id "+(i+1) + " "+pochidex[i, nombre] + " esta sin investigar");
                            }
                        }
                        Console.Write("Cual queres investigar?, Decime el numero de id:");
                        int fila = int.Parse(Console.ReadLine());

                        pochidex[(fila-1), estado] = "1";

                        Console.Write("Cual es tu codigo de investigador?:");
                        idi = Console.ReadLine();
                        pochidex[(fila-1), investigador] = idi;
                        
                        break;

                    case 3:
                        Console.WriteLine("Cual es tu codigo de investigador?");
                        idi = Console.ReadLine();
                        Console.WriteLine("Pochimons registrados:");
                        Console.WriteLine("| Fila |     Nombre   |  Nivel |");
                        Console.WriteLine("| ------| ------------| -------|");
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, investigador] == idi)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" +"|" +pochidex[i,nombre]+ "\t"+"\t"+"|"+ pochidex[i,nivel]);
                            }
                        }
                        Console.Write("Decime el numero de id del pochimon que queres investigar:");
                        fila = int.Parse(Console.ReadLine());

                        int niv = int.Parse(pochidex[(fila-1), nivel]);
                        
                        pochidex[(fila - 1), nivel] = (niv + random.Next(1,3)).ToString();
                        
                        Console.WriteLine(pochidex[(fila-1), nivel]);
                        
                        Console.ReadLine();
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
                    case 9:
                        Console.WriteLine("Chauuu");
                        salir = true;
                        break;
                    default:Console.WriteLine("Error");
                        break;
                }
                Console.Clear();
            } while (!salir);
            Console.ReadKey();
        }
    }
}





