using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Etapa_1
{
    class HOLA
    {
        static void Main(string[] args)
        {
            bool pasable = true;
            Console.Write("Decime tu contraseña:");
            string contra = Console.ReadLine();

            Console.Write("Para entrar necesitas una contraseña, decimela:");
            string nuevacontra = Console.ReadLine();


            for (int i = 0; i < contra.Length; i++)
            //el .Length sirve para saber cuantos caracteres tengo en un string
            {
                //voy viendo cada caracter.
                char a = contra[i], b = nuevacontra[i];
                if (a != b && !(a + 32 == b || a - 32 == b))
                {
                    pasable = false;
                    //aca corroboro si el caracter a no es igual a b, en la segunda condicion veo si a + 32 sea igual a b, porque en la tabla ascii la diferencia de cada caracter minuscula
                    //con la mayuscula es de 32, asi sacando que no sea solamente un error de sensibilidad a la mayuscula.
                }
            }

            if (pasable == true)
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Mal");
            }
            Console.ReadKey();
        }
    }
}
