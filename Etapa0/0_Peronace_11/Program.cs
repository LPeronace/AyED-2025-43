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

            Console.Write("Decime el ancho:");
            int anch = int.Parse(Console.ReadLine());

            Console.Write("Decime la altura:");
            int alt = int.Parse(Console.ReadLine());

            int perimetro = 2 * (anch + alt);
            int area = anch * alt;
            double diagonal = Math.Sqrt(Math.Pow(anch, 2) + Math.Pow(alt, 2));

            Console.WriteLine("Dado el ancho:" + anch + " y la altura:" + alt + " el perimetro es:" + perimetro + ",el area es:" + area + " y la diagonal es:" + diagonal);
            Console.ReadKey();
        }
    }
}
