using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos productos vendiste en todo el hot sale?");
            int[] cantidad = new int[int.Parse(Console.ReadLine())];
            int[] precio = new int[cantidad.Count()];
            for (int i = 0; i < cantidad.Count(); i++)
            {
                Console.WriteLine("Y a cuanto cobraste el producto " + (i + 1) + "?");
                precio[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < precio.Count() - 1; i++)
            {
                for (int j = 0; j < precio.Count() - i - 1; j++)
                {

                    if (precio[j] < precio[j + 1])
                    {
                        int residuo = precio[j];
                        precio[j] = precio[j + 1];
                        precio[j + 1] = residuo;
                    }
                }
            }
            Console.WriteLine("El precio mas alto fue:" + precio[0] + " y el precio mas bajo:" + precio[precio.Count() - 1]);

            Console.ReadKey();
        }
    }
}

