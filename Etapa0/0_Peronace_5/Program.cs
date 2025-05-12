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
            string a;

            Console.WriteLine("Decime un Numero");
            a = Console.ReadLine();
            int n1 = int.Parse(a);

            Console.WriteLine("Decime otro");
            a = Console.ReadLine();
            int n2 = int.Parse(a);

            int resta = n1 - n2;
            Console.WriteLine("La resta de los dos numeros es:" + resta);

            Console.ReadKey();
        }
    }
}