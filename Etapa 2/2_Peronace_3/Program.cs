using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos participantes hay?");
            int[] personas =new int[int.Parse(Console.ReadLine())];
            int[] puntaje = new int[personas.Count()];
            int[] ordenado = new int[personas.Count()];
            for (int i = 0; i < personas.Count(); i++)
            {
                Console.WriteLine("Cuanto puntaje hizo el participante numero " + (i + 1) + " ?");
                puntaje[i] = int.Parse(Console.ReadLine());
            }

            for(int a = 0; a < personas.Count(); a++)
            {
                int residuo = 0;
                if()
            }

            Console.ReadKey();
        }
    }
}
