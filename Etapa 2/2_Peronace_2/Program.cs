using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaltp = 0, totalexamen = 0;

            Console.WriteLine("Cuantos tps tenes?");
            int[] cantidadtp = new int[int.Parse(Console.ReadLine())];
            int[] notatp = new int[cantidadtp.Count()];

            Console.WriteLine("Cuantos pruebas tenes?");
            int[] cantidadexamen = new int[int.Parse(Console.ReadLine())];
            int[] notaexamen = new int[cantidadexamen.Count()];

            for (int i = 0; i < cantidadtp.Count(); i++)
            {
                Console.WriteLine("Nota del tp "+ (i+1)+" ?");
                notatp[i] = int.Parse(Console.ReadLine());
                totaltp += notatp[i];
            }
            for (int i = 0; i < cantidadexamen.Count(); i++)
            {
                Console.WriteLine("Nota de la prueba " + (i + 1) + " ?");
                notaexamen[i] = int.Parse(Console.ReadLine());
                totalexamen += notaexamen[i];
            }
            double promedioxamen = totalexamen / cantidadexamen.Count();
            double porcentaje = (75 / totaltp) * 100;

            if (promedioxamen >= 6 && porcentaje >= 6) 
            {
                Console.WriteLine("Aprobaron!!!");
            }
            else
            {
                Console.WriteLine("Desaprobaron :(");
            }

            Console.ReadKey();
        }
    }
}
