using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do
            {
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("El numero "+numero+ "=Fizzbuzz");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine("El numero " + numero + "= fizz");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine("El numero " + numero + "=buzz");
                }
                else
                {
                    Console.WriteLine("El numero " + numero + " no es nada");
                }
                numero++;

            } while (numero <= 100);
            Console.ReadKey();
        }
    }
}
