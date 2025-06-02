namespace _2_Peronace_11 
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De cuanto tamaño va a ser la matriz rotada?");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];
            Random aleatorio = new Random();

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 100);
                    //matriz[i,j] = int.Prase(i.ToString() + j.ToString());
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
            for(int i = 0; i < n; i++)
            {
                for(int j = (n-1) ; j >= 0 ; j--)
                {
                    Console.WriteLine(matriz[j,i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
