using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas vueltas hiciste?:");
            int vueltas = int.Parse(Console.ReadLine());
            int[] tiempo = new int[vueltas];

            int tiempototal = 0, vueltarapida=9999999;

            for(int i = 0; i < vueltas; i++)
            {
                Console.Write("Tiempo de vuelta?:");
                tiempo[i] = int.Parse(Console.ReadLine());
                tiempototal += tiempo[i];
                
                if(vueltarapida > tiempo[i])
                {
                    vueltarapida = tiempo[i];
                }
            }
            double promedio = tiempototal / vueltas;

            Console.WriteLine("El tiempo total fue:" + tiempototal+ " segundos, el promedio:"+promedio +" segundos y la vuelta mas rapida:"+vueltarapida +" segundos");


            Console.ReadKey();
        }
    }
}
