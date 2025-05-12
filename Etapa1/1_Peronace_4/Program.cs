using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuanto cobras?:");
            int sueldo = int.Parse(Console.ReadLine());
            Console.Write("Cuantos años tenes?");
            int edad = int.Parse(Console.ReadLine());

            if (edad> 19 && sueldo <= 100000 || edad<19 && sueldo == 0 || edad == 19 && sueldo<=50000 )
            {
                Console.WriteLine("Cobras");
            }
            Console.ReadLine();
        }
    }
}
