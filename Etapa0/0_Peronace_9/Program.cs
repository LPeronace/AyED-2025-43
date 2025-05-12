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
            Console.WriteLine("Decime el Radio");
            double radio = double.Parse(Console.ReadLine());

            double sup = 4 * Math.PI * Math.Pow(radio, 2);

            double vol = (4 / 3) * Math.PI * Math.Pow(radio, 3);

            Console.WriteLine("La superficie es:" + sup + " y el volumen es:" + vol);

            Console.ReadKey();
        }
    }
}