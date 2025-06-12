using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos alumnos tenes?");
            int alumno = int.Parse(Console.ReadLine());
            string[,] matriz = new string[alumno, 3];

            int j = 0;

            for(int i = 0; i < alumno; i++)
            {
                Console.Write("Decime el nombre del alumno "+(i+1)+":");
                matriz[i, j] = Console.ReadLine();

                Console.Write("Cuantos años tiene el alumno" + (i + 1) + "?:");
                matriz[i, j + 1] = (int.Parse(Console.ReadLine())).ToString();

                Console.Write("Y que nota tiene el alumno" + (i + 1) + "?:");
                matriz[i, j + 2] = (int.Parse(Console.ReadLine())).ToString();

            }
            for(int i = 0; i < alumno; i++)
            {
                for(int v = 0; v < alumno; v++)
                {
                    Console.Write(matriz[i, v]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
