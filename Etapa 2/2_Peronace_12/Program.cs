using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime cuanto tamaño tiene la matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,n];
            int[] vector = new int[n];
            Random aleatorio = new Random();
            int v = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j=0; j < n; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 100);
                    Console.Write(matriz[i, j]+"\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < n; i++)
            {
                vector[i] = matriz[i, v];
                v++;
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
