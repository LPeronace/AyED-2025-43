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
            int[] personas = new int[int.Parse(Console.ReadLine())];
            int[] puntaje = new int[personas.Count()];


            for (int i = 0; i < personas.Count(); i++)
            {
                Console.WriteLine("Cuanto puntaje hizo el participante numero " + (i + 1) + " ?");
                puntaje[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < puntaje.Length - 1; i++)
            {
                for (int j = 0; j < puntaje.Length - i - 1; j++)
                {
                    if (puntaje[j] < puntaje[j + 1])
                    {
                        // Intercambio de valores
                        int residuo = puntaje[j];
                        puntaje[j] = puntaje[j + 1];
                        puntaje[j + 1] = residuo;
                    }
                }

            }

            for (int i = 0; i < puntaje.Length; i++)
            {
                Console.WriteLine("El puesto " + (i + 1) + " tuvo un puntaje de: " + puntaje[i]);
            }

            Console.ReadKey();
        }
    }
}