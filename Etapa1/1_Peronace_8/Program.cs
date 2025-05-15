using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos años tenes?");
            int edad = int.Parse(Console.ReadLine());

            for(int i = 1; i < edad; i++)
            {
                Console.WriteLine("Cumpliste " + i + " años!!!");
            }

            Console.ReadKey();

        }
    }
}
