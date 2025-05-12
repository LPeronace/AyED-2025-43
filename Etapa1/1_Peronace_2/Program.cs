using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decime un numero:");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Decime otro numero:");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                double division = n1 / n2;
                Console.WriteLine("El resultado de la division es:" + division);
            }
            Console.ReadKey();
        }
    }
}
