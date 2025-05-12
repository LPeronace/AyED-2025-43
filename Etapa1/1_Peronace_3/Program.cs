using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decime un numero entero:");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Es cero");
            }
            else if (numero %2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
        }
    }
}
