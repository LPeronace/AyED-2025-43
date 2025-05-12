using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime que edad tenes porfavor");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Sos mayor!");
            }
            else
            {
                Console.WriteLine("Sos menor :(");
            }
        }
    }
}
