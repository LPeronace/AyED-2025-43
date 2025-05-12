using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decime tu nombre:");
            string nombre = Console.ReadLine();

            Console.Write("Decime tu edad:");
            string edad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " tu edad es:" + edad);
            Console.ReadKey();
        }
    }
}