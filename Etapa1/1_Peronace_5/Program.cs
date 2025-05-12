using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tenes Comida?(si o no):");
            string comida = Console.ReadLine().ToLower();

            Console.Write("Tenes Refugio?(si o no):");
            string refugio = Console.ReadLine().ToLower();

            Console.Write("Tenes un bate?(si o no):");
            string bate = Console.ReadLine().ToLower();

            if (comida == "si" && refugio == "si" && bate == "si")
            {
                Console.WriteLine("Sobrevivis!!!!");
            }
            else
            {
                Console.WriteLine("Ja te va a morir");
            }
            Console.ReadKey();
        }
    }
}
