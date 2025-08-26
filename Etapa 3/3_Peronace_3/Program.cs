using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_3
{
    class Program
    {
        static int[] vector = new int[3];
        static void menu(string[,] encargo)
        {
            bool ocupado = true, noocupado = false,check = false; 
            int codcamion = 0, distancia = 1, sede = 2, ganancia = 3, asignado = 4, opcion = 0, detector = 0,d = 0;
            do
            {
                Console.WriteLine("Elegi una de estas opciones:" + "\n" + "1 para crear nuevo encargo" + "\n" + "2 para mostrar todos los encargos" + "\n" + "3 para asignar un camion al encargo" + "\n" + "4 para mostrar todos los encargos asignados" + "\n" + "5 para promedio de ganancia por sede" + "\n" + "6 para mostrar el encargo con mayor distancia" + "\n" + "7 para filtrar encargo por el codigo del camion" + "\n" + "8 para salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (encargo[24, 0] != "")
                        {
                            Console.WriteLine("Bueno, te voy a pedir unos datos.. ");
                            do
                            {
                                Console.WriteLine("Distancia recorrida?");
                                d = int.Parse(Console.ReadLine());
                                if(d <= 0)
                                {
                                    check = false;
                                    Console.WriteLine("Error, intenta devuelta");
                                    d = int.Parse(Console.ReadLine());
                                    break;
                                }
                                else
                                {
                                    encargo[detector, distancia] = d.ToString();
                                    check = true;
                                }
                            } while (!check);
                            Console.WriteLine("La sede?(1 para BSAS, 2 para BB y 3 para MDQ):");
                            encargo[detector, sede] = Console.ReadLine();
                            Console.WriteLine("Y la ganancia?");
                            encargo[detector, ganancia] = Console.ReadLine();
                            encargo[detector, asignado] = "0";
                            detector++;
                        }
                        else
                        {
                            Console.WriteLine("Los encargos estan llenos,completa algunos primero");
                        }

                        break;
                    case 2:
                        leermatriz(encargo, detector,noocupado);
                        break;
                    case 3:
                        leermatriz(encargo, detector, noocupado);
                        Console.WriteLine("Decime el codigo de camion que le queres poner:");
                        int reciclar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y cual queres seleccionar?");
                        int seleccion = int.Parse(Console.ReadLine())-1;
                        if(encargo[seleccion,asignado] == "0")
                        {
                            Console.WriteLine("Encargo registrado");
                            encargo[seleccion, codcamion] = reciclar.ToString();
                            encargo[seleccion, asignado] = "1";
                        }
                        else
                        {
                            Console.WriteLine("Error, intente devuelta");
                        }
                        break;
                    case 4:
                        leermatriz(encargo, detector, ocupado);
                        break;
                    case 5:
                        saldo(encargo, detector);
                        Console.WriteLine("El promedio de la ganancia de la sede bsas es:"+vector[0]+" y el de la sede de bb es:"+vector[1]+" y el de mdq es:"+vector[2]);

                        break;
                    case 6:distanciamaxima(encargo, detector);

                        break;
                    case 7:filtrado(encargo, detector);
                        break;
                    case 8:
                        break;
                }
                Console.WriteLine("Presione una tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 8);
        }
        static void leermatriz(string [,] encargo,int para, bool ocupacion)
        {
            int codcamion = 0, distancia = 1, sede = 2, ganancia = 3, asignado = 4;
            for (int i = 0; i <= para; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!ocupacion)
                    {
                        Console.WriteLine(encargo[i, j] + " ");
                    }
                    else if (ocupacion)
                    {
                        if(encargo[i,asignado] == "1")
                        {
                            Console.WriteLine(encargo[i, j] + " ");
                        }
                    }
                    else
                        {
                            Console.Write(encargo[i, j] + " ");
                        }
                }
            }
        }
        static void saldo(string[,] encargo, int para)
        {
            int a = 0, b = 0, c = 0, bsas = 0, bb = 0, mdq = 0;
            for(int i = 0;i< para; i++)
            {
                Console.Write("El encargo"+(i+1)+" ");
                for(int j = 0;j< 5; j++)
                {
                    if(encargo[i,2] == "1")
                    {
                        bsas += int.Parse(encargo[i, 3]);
                        a++;
                    }
                    else if (encargo[i, 2] == "2")
                    {
                        bb += int.Parse(encargo[i, 3]);
                        b++;
                    }
                    else if (encargo[i, 2] == "3")
                    {
                        mdq += int.Parse(encargo[i, 3]);
                        c++;
                    }
                }
            }
            vector[0] = bsas / a;
            vector[1] = bb / b;
            vector[2] = mdq / c;
        }
        static void distanciamaxima(string[,] encargo,int para)
        {
            int distancia = 0,identidad = 0;
            for(int i = 0; i < para; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(distancia< int.Parse(encargo[i, 1]))
                    {
                        distancia = int.Parse(encargo[i, 1]);
                        identidad = i;
                    }
                }
            }
            Console.WriteLine("El encargo con mayor distancia es el numero:"+(identidad+1)+" y tiene una distancia de:"+distancia+" y la sede es:"+encargo[identidad,2]+" y la ganancia es:"+encargo[identidad,3]);
        }
        static void filtrado(string[,] encargo, int para)
        {
            Console.WriteLine("Decime un codigo de camion");
            int id = int.Parse(Console.ReadLine());
            for(int i = 0; i < para; i++)
            {
                if (int.Parse(encargo[i, 0]) == id)
                {
                    Console.WriteLine("El encargo " + (i + 1) + " coincide con el codigo de camion, tiene una distancia de:" + encargo[i, 0] + " y va hacia la sede:" + encargo[i, 1] + " y tiene una ganancia de:" + encargo[i, 3]);
                }
                else
                {
                    Console.WriteLine("No hay ningun encargo con esa id de camion");
                }
            }
        }
        static void Main(string[] args)
        {
            string[,] encargo = new string[25, 5];
            menu(encargo);       
        }
    }
}
