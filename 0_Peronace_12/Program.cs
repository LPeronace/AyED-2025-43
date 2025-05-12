using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Decime tres letras:");
            string letras = Console.ReadLine();


            Console.WriteLine("tus letras son:" + letras + " y el invertido de esas 3 letras es:" + letras[2] + letras[1] + letras[0]);
            Console.ReadKey();

        }
    }
}
