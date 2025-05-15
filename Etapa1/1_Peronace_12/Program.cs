using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            do
            {
                Console.WriteLine("Diga SI para terminar");
                Console.Write("Queres terminar? ");
                a = Console.ReadLine();
            } while (a != "SI");
            Console.ReadKey();
        }
    }
}
