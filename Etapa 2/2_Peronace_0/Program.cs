using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Cuantos invitados tenes?");
            int[] invitados = new int[int.Parse(Console.ReadLine())];
            int[] comida = new int[invitados.Count()];

            for (int i = 0; i < invitados.Count(); i++)
            {
                Console.WriteLine("Y Cuanta comida come el invitado "+ (i+1)+"? (de 1 a 100)");
                comida[i] = int.Parse(Console.ReadLine());

                total += comida[i];
                double promedio = total / invitados.Count();
                Console.WriteLine("El total es:" + total + " y el promedio es:"+promedio); 
            }
            Console.ReadKey();
        }
    }
}
