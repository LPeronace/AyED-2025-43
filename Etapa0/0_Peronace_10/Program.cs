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
            Console.Write("Decime cuantos grados hace (en Celsius):");
            int celcius = int.Parse(Console.ReadLine());

            double fah = (celcius * 9 / 5) + 32;
            double kelvin = celcius + 273.15;

            Console.WriteLine("Actualmente esta haciendo " + fah + " grados fahrenheit y " + kelvin + " grados kelvin");
            Console.ReadKey();
        }
    }
}