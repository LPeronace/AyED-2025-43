using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_0
{
    class Program
    {
        static string saludo(string nombre)
        {
            return "Hola," + nombre;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Decime tu nombre");
            string a = Console.ReadLine();
            Console.WriteLine(saludo(a));
            Console.ReadKey();
        }
    }
}
