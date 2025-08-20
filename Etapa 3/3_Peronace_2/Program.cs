using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_2
{
    class Program
    {
        static int suma(int a,int b)
        {
            return a + b;
        }
        static int resta(int a,int b)
        {
            return a - b;
        }
        static int multi(int a, int b)
        {
            return a * b;
        }
        static int divi(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
            Console.WriteLine("Decime el primer numero");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Decime el segundo numero");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1 para sumar" + "\n" + "2 para restar" + "\n" + "3 para multiplicar" + "\n" + "4 para dividir"+"\n"+"5 para salir");
            Console.Write("Que queres hacer?:");
            string opcion = Console.ReadLine();
                switch (opcion)
                { 
                    
                    case "1":Console.WriteLine("El resultado es:"+suma(v1, v2));
                    break;
                    case "2":Console.WriteLine("El resultado es:" + resta(v1, v2));
                        break;
                    case "3": Console.WriteLine("El resultado es:" + multi(v1, v2));
                        break;
                    case "4": Console.WriteLine("El resultado es:" + divi(v1, v2));
                        break;
                    case "5": salir = true;
                        break;
                }
            }while (!salir);
            
        }
    }
}
