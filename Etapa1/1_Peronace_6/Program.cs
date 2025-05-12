using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Peronace_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A cuantos grados tenes el agua? en celcius porfavor:");
            int grados = int.Parse(Console.ReadLine());

            if (grados <= 0)
            {
                Console.WriteLine("se te congelo");
            }
            else if(grados>= 100)
            {
                Console.WriteLine("esta hirviendo!!!");
            }
            else
            {
                Console.WriteLine("Esta en estado liquido");
            }
            Console.ReadKey();
        }
    }
}
