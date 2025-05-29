using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos candidatos hicieron el examen?");
            int candidatos = int.Parse(Console.ReadLine());

            int[] puntaje = new int[candidatos];

            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("Cuanto puntaje saco el candidato numero " + (i + 1) + "?");
                puntaje[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < candidatos; i++)
            {
                for(int j  = i; j < candidatos; j++)
                {
                    if (puntaje[i] > puntaje[j])
                    {
                        int aux = 0;
                        aux = puntaje[i];
                        puntaje[i] = puntaje[j];
                        puntaje[j] = aux;
                    }
                }
            }
            Console.WriteLine("Y cual es el filtro?");
            int filtro = int.Parse(Console.ReadLine());

            for(int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("Puntaje:" + puntaje[i]);
            }

            for(int i = 0; i < candidatos; i++)
            {
                if (puntaje[i] % filtro == 0)
                {
                    Console.WriteLine("El puntaje "+puntaje[i]+ " es multiplo del filtro");
                }
            }

            Console.ReadKey();
        }
    }
}
