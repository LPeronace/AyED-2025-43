namespace _2_Peronace_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De cuanto tamaño queres que sean las matrices?");
            int n = int.Parse(Console.ReadLine());

            int[,] tabla0 = new int[n, n];
            int[,] tabla1 = new int[n, n];
            int[,] suma = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    tabla0[i, j] = rand.Next(0, 100);
                    tabla1[i, j] = rand.Next(0, 100);

                    suma[i, j] = tabla0[i, j] + tabla1[i, j];
                    Console.Write(suma[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
