using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos objetos queres analizar?");
            int objetos = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el minimo de precio de los objetos para que sean considerados en el filtro?");
            double filtro = double.Parse(Console.ReadLine());

            int[] valores = new int[objetos];


            for(int i = 0; i < objetos; i++)
            {
                Console.WriteLine("Que valor tiene el objeto " + (i + 1)+" ?");
                valores[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < objetos; i++)
            {
                if (valores[i] > filtro)
                {
                    Console.WriteLine("El objeto en la posicion " + (i + 1) + " es mayor al filtro que pusiste");
                }
            }
            Console.ReadKey();
        }
    }
}
