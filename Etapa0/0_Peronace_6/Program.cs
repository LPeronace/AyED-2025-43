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
            Console.WriteLine("Decime un Numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Decime otro");
            int n2 = int.Parse(Console.ReadLine());

            int multi = n1 * n2;
            Console.WriteLine("La multiplicacion de los dos numeros es:" + multi);

            Console.ReadKey();
        }
    }
}