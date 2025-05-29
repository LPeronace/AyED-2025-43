using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Peronace_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Cuanto tamaño queres que tenga el vector?");
            int[] vector = new int[int.Parse(Console.ReadLine())];

            for(int i = 0; i < vector.Count(); i++)
            {
                int aleatorio = rand.Next(1, 101);
                vector[i] = aleatorio;
            }

            bool salir = false;
            do
            {
                Console.WriteLine("Bienvenido al menu interactuable. Seleccione una de estas 4 opciones" + "\n" + "1 para imprimir todos los elementos del vector en pantalla" + "\n" + "2 para buscar un numero que vos ingreses" + "\n" + "3 para ordernar el vector de forma ascendente o descendente" + "\n" + "4 para salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        for(int i = 0; i < vector.Count(); i++)
                        {
                            Console.WriteLine("El numero del vector en la posicion " + (i + 1)+" es:"+vector[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Decime el numero que queres buscar");
                        int numero = int.Parse(Console.ReadLine());
                        bool noencontre = true;
                        for (int i = 0; i < vector.Count(); i++)
                        {
                            if(numero == vector[i])
                            {
                                Console.WriteLine("El numero se repite en la posicion:" + (i + 1));
                                noencontre = false;
                            }
                            
                        }
                        if (noencontre)
                        {
                            Console.WriteLine("No se encontro el numero que pusiste");
                        }

                        break;
                    case 3:
                        Console.WriteLine(" Queres ordenarlo de forma descendente (opcion 1) o ascendente (opcion 2) ? ");
                        int ordenamiento = int.Parse(Console.ReadLine());
                        if (ordenamiento == 2 )
                        {
                            for (int i = 0; i < vector.Count(); i++)
                            {
                                for( int j = i; j < vector.Count(); j++ )
                                {
                                    if (vector[i] < vector[j])
                                    {
                                        int aux = 0;
                                        aux = vector[i];
                                        vector[i] = vector[j];
                                        vector[j] = aux;
                                    }
                                   
                                }
                            }
                        }
                        if (ordenamiento == 1)
                        {
                            for (int i = 0; i < vector.Count(); i++)
                            {
                                for (int j = i; j < vector.Count(); j++)
                                {
                                    if (vector[i] > vector[j])
                                    {
                                        int aux = 0;
                                        aux = vector[i];
                                        vector[i] = vector[j];
                                        vector[j] = aux;
                                    }

                                }
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine(" CHAU ");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine(" ERROR ");
                        break;
                }

            } while (!salir);
        }
    }
}
