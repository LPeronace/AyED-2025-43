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
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Decime otro");
            double n2 = double.Parse(Console.ReadLine());

            double resto = n1 % n2;
            Console.WriteLine("El resto de los dos numeros es:" + resto);

            Console.ReadKey();
        }
    }
}