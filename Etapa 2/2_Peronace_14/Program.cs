using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
//using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2_Peronace_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pochidex = new string[75, 5];
            bool salir = false, checkeo = false;
            int encontrado = 0;
            int nombre = 0;
            int tipo = 1;
            int nivel = 2;
            int estado = 3;
            int investigador = 4;
            int idi;
            int k;
            Random random = new Random();
            do
            {
                Console.WriteLine("Bienvenido a la pochidex, que queres hacer?" + "\n" + "Cantidad encontrada:" + (encontrado) + "/75" + "\n" + "1 para registrar Pochimon" + "\n" + "2 para Asignar Investigador A Pochimon" + "\n" + "3 para actualizar nivel de Pochimon" + "\n" + "4 para marcar Pochimon como investigado" + "\n" + "5 para mostrar informacion de Pochimons" + "\n" + "6 para buscar Pochimons por Tipo" + "\n" + "7 para mostrar Pochimon por investigador" + "\n" + "8 para mostrar Pochimons picados" + "\n" + "9 para salir de la pochidex");
                string opcion = Console.ReadLine();
                Random rand = new Random();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Y cual es el nombre?:");
                        pochidex[encontrado, nombre] = Console.ReadLine();

                        do
                        {
                            Console.Write("Y el tipo?(A = Agua, F = Fuego y P = Planta):");
                            string lectura = Console.ReadLine();
                            if (lectura.ToUpper() == "A" || lectura.ToUpper() == "F" || lectura.ToUpper() == "P")
                            {
                                pochidex[encontrado, tipo] = lectura.ToUpper();
                                checkeo = true;
                            }
                            else
                            {
                                Console.WriteLine("Error, intente de nuevo");
                                checkeo = false;
                            }
                        } while (!checkeo);

                        Console.Write("Y el nivel?:");
                        string n = Console.ReadLine();
                        do
                        {
                            if (int.TryParse(n, out k))
                            {
                                pochidex[encontrado, nivel] = n;
                                checkeo = true;
                            }
                            else
                            {
                                Console.WriteLine("Error, intentelo devuelta");
                                n = Console.ReadLine();
                                checkeo = false;
                            }
                        } while (!checkeo);

                        pochidex[encontrado, estado] = "0";

                        pochidex[encontrado, investigador] = "0";

                        encontrado += 1;
                        break;
                    case "2":
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, estado] == "0")
                            {
                                Console.WriteLine("El Pokemon " + "con id " + (i + 1) + " " + pochidex[i, nombre] + " esta sin investigar");
                            }
                        }
                        Console.Write("Cual queres investigar?, Decime el numero de id:");
                        int fila = int.Parse(Console.ReadLine());
                        

                        pochidex[(fila - 1), estado] = "1";

                        do
                        {
                            Console.Write("Cual es tu codigo de investigador?:");
                            idi = int.Parse(Console.ReadLine());
                            if (idi.ToString().Trim() == "")
                            {
                                Console.WriteLine("Codigo invalido, intente denuevo");
                                checkeo = false;
                            }
                            else
                            {
                                pochidex[(fila - 1), investigador] = idi.ToString();
                                checkeo = true;
                            }
                        } while (!checkeo);
                        break;

                    case "3":
                        Console.WriteLine("Pochimons registrados:");
                        Console.WriteLine("| ID |     Nombre   |  Nivel |");
                        Console.WriteLine("| ------| ------------| -------|");
                        for (int i = 0; i < encontrado; i++)
                        {
                            Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, nivel]);
                        }
                        Console.Write("Decime el numero de id del pochimon que queres investigar:");
                        fila = int.Parse(Console.ReadLine());

                        int niv = int.Parse(pochidex[(fila - 1), nivel]);

                        pochidex[(fila - 1), nivel] = (niv + random.Next(1, 3)).ToString();
                        Console.WriteLine("El nuevo nivel del Pochimon es... " + pochidex[fila - 1, nivel] + "!!!");
                        break;

                    case "4":
                        Console.WriteLine("Pochimons En Investigacion:");
                        Console.WriteLine("| ID |     Nombre   |  Tipo | Nivel | Estado | Investigador Asignado|");
                        Console.WriteLine("| |------|------------|-------|-------|--------|-----------------------|");
                        for (int i = 0; i < encontrado; i++)
                        {
                            for (int j = 0; j < encontrado; j++)
                            {
                                if (pochidex[i, estado] == "1")
                                {
                                    Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                                }
                            }
                        }

                        Console.WriteLine("Decime el numero de id el cual queres marcar como investigado:");
                        fila = int.Parse(Console.ReadLine());

                        pochidex[(fila - 1), estado] = "2";
                        break;
                    case "5":
                        Console.WriteLine("| ID |     Nombre   |  Tipo | Nivel | Estado | Investigador Asignado|");
                        Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");
                        for (int i = 0; i < encontrado; i++)
                        {
                            for (int j = 0; j < encontrado; j++)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }
                        break;
                    case "6":
                        Console.Write("Que tipo de pochimon queres buscar? (A/F/P):");
                        string buscado = (Console.ReadLine()).ToUpper();

                        do
                        {
                            if (buscado == "A" || buscado == "F" || buscado == "P")
                            {
                                checkeo = true;
                            }
                            else
                            {
                                Console.WriteLine("Error, no es un tipo válido, intente devuelta");
                                buscado = Console.ReadLine();
                                checkeo = false;
                            }

                        } while (!checkeo);
                        Console.WriteLine("| ID |     Nombre   |  Tipo | Nivel | Estado | Investigador Asignado|");
                        Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");
                        for (int i = 0; i < encontrado; i++)
                        {
                            if (buscado == pochidex[i, tipo])
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }

                        break;
                    case "7":
                        do
                        {
                            checkeo = false;

                        } while (!checkeo);
                        Console.Write("Decime cual es tu codigo de investigador:");
                        string idibuscado = Console.ReadLine();
                        Console.WriteLine("Todos los pochimones asignados al numero de investigador:" + idibuscado);
                        Console.WriteLine("| ID |     Nombre   |  Tipo | Nivel | Estado | Investigador Asignado|");
                        Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");

                        for (int i = 0; i < encontrado; i++)
                        {
                            for (int j = 0; j < encontrado; j++)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }


                        break;
                    case "8":
                        Console.WriteLine("Todos los pochimones que tienen un nivel mayor a 30 son:");

                        Console.WriteLine("| ID |     Nombre   |  Tipo | Nivel |");
                        Console.WriteLine("|------|------------|-------|-------|");
                        for (int i = 0; i < encontrado; i++)
                        {
                            if (int.Parse(pochidex[i, nivel]) > 30)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t");
                            }
                        }
                        break;
                    case "9":
                        Console.WriteLine("Chauu");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                if (opcion != "9")
                {
                    Console.WriteLine("Presione una tecla para seguir");
                    Console.ReadKey();
                }
                do
                {
                    if (opcion.Trim() == "")
                    {
                        Console.WriteLine("Intentelo devuelta");
                        opcion = Console.ReadLine();
                        checkeo = false;
                    }
                    else
                    {
                        checkeo = true;
                    }
                } while (!checkeo);
                Console.Clear();
            } while (!salir);
        }
    }
}