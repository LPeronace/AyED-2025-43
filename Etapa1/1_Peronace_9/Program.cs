using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decime un numero:");
            int numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                Console.WriteLine("Cuenta regresiva:" + numero);
                numero--;
            }

            Console.ReadKey();
        }
    }
}
