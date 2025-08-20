using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_1
{
    class Program
    {
        static int calculo(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Decime el primer numero");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Decime el segundo numero");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es:" + calculo(v1, v2));
            Console.ReadKey();
        }
    }
}
