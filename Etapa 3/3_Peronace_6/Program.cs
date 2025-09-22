using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Peronace_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mano = GenerarMano();

            string tipo = TipoMano(mano);

            int puntaje = PuntajeBase(mano);

            double multi = multiplicador(tipo);

            double total = puntaje * multi;

            bool jokerx2 = true, jokermas10=true;
            total = aplicarjokers(total, jokerx2, jokermas10);

            mostrarresumen(mano, tipo, puntaje, multi, total);
            Console.ReadKey();
        }
        static string[] GenerarMano()
        {
            string[] checkfichas = { "a", "k" , "q" , "j" ,"t", "9" , "8" , "7", "6" , "5" , "4" , "3" , "2" };

            string[] checkpalo = { "H" , "D" , "C" , "S" };

            string[] fichas = new string[5];
            string[] palo = new string[5];
            string[] cartas = new string[5];

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int b = 0;
                b = rand.Next(0, 12);
                fichas[i] = checkfichas[b];
                b = rand.Next(0, 3);
                palo[i] = checkpalo[b];
                cartas[i] = fichas[i] + palo[i];
            }
            return cartas;
        }
        static string TipoMano(string[] a)
        {
            string tipodemano = "",reciclo = "",reciclo2 = "";
            
            for(int i = 0; i < 5; i++)
            {
                reciclo = a[i];
                reciclo2 += reciclo[0];
            }
            tipodemano = Poker(reciclo2);
            return tipodemano; 
        }
        static string Poker(string recliclo2)
        {
            string tipo ="";
            bool a = false;
            int contador = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = i+1; j < 5; j++)
                {
                    if (recliclo2[i] == recliclo2[j])
                    {
                        contador++;
                    }
                }
            }
            switch (contador)
            {
                case 6: tipo = "poker";
                    break;
                case 4: tipo = "full";
                    break;
                case 3: tipo = "trio";
                    break;
                case 1: tipo = "par";
                    break;
                default: tipo = "nada";
                    break;
            }
            return tipo;
        }
        static int PuntajeBase(string[] a)
        {
            string reciclo = "";
            string reciclo2 = "";
            int puntaje = 0;

            for (int i = 0; i < 5; i++)
            {
                reciclo = a[i];
                reciclo2 += reciclo[0];
                char x = reciclo2[i];
                switch (x)
                {
                    case 'a': puntaje += 14;
                        break;
                    case 'k': puntaje += 13;
                        break;
                    case 'q': puntaje += 12;
                            break;
                    case 'j': puntaje += 11;
                        break;
                    case 't': puntaje += 10;
                        break;
                    default: puntaje += (x-'0');
                        break;
                }
            }
            return puntaje;
        }
        static double multiplicador(string tipodemano)
        {
            double multi = 0;
            switch (tipodemano)
            {
                case "poker":
                    multi = 4;
                    break;
                case "full":
                    multi = 3.5;
                    break;
                case "trio":
                    multi = 2.5;
                    break;
                case "par":
                    multi = 1.5;
                    break;
                case "nada":
                    multi = 1;
                    break;
            }
            return multi;
        }
        static double aplicarjokers(double total,bool jokerx2, bool jokermas10)
        {
            if (jokerx2)
            {
                total = total * 2;
            }
            if (jokermas10)
            {
                total += 10;
            }
            return total;
        }
        static void mostrarresumen(string[] a,string tipo,int puntaje,double multi,double total)
        {
            Console.WriteLine("Las cartas son:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Por lo cual es:" + tipo);
            Console.WriteLine("Con un puntaje de:" + puntaje);
            Console.WriteLine("Y un multi de:" + multi);
            Console.WriteLine("Por lo cual da(Con jokers incluidos):"+total);
        }
    }
}
