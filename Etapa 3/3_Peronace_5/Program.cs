using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpHornet = 10, hpmaxhornet = 10, atkHornet = 3, hpEnemigo = 12;
            Console.WriteLine("Hollow Knight: Simulador Basico");
            while(hpHornet >0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.WriteLine("\nAccion (atacar/curar/salir)");
                string accion = Console.ReadLine();

                if(accion == "atacar")
                {
                    hpEnemigo = atacar(atkHornet, hpEnemigo);
                }
                else if(accion == "curar")
                {
                    hpHornet = curar(hpHornet, hpmaxhornet);
                }
                else if(accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Accion no valida");
                }
                if(hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataco y te saco 2 de vida :(");
                }
            }
            Console.WriteLine("\n ===Resultado===");
            if(hpHornet <= 0)
            {
                Console.WriteLine("Ganaron los bichos..");
            }
            else if(hpEnemigo <= 0)
            {
                Console.WriteLine("Gano Hornet!");
            }
            else if(hpHornet <=0 && hpEnemigo <= 0)
            {
                Console.WriteLine("Empataste....");
            }
            else
            {
                Console.WriteLine("Batalla Interrumpida");
            }
            Console.ReadKey();
        }
        static int atacar(int ataquehornet, int vidaenemigo)
        {
            vidaenemigo = vidaenemigo - ataquehornet;
            return vidaenemigo;
        }
        static int curar(int vidahornet, int vidamaxima)
        {
            if(vidahornet< vidamaxima)
            {
                vidahornet += 5;
                if(vidahornet >= 10)
                {
                    vidahornet = vidamaxima;
                }
            }
            return vidahornet;
        }
        static void MostrarEstado(int vidahornet, int vidaenemigo)
        {
            Console.WriteLine("La vida de hornet va a ser:" + vidahornet + " y la vida del enemigo es:" + vidaenemigo);
            
        }
    }
}
