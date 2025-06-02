namespace _2_Peronace_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas filas queres que tenga tu tabla?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas columnas queres que tenga tu tabla?");
            int m = int.Parse(Console.ReadLine());


            int[,] tabla = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine(tabla[i, j]);
                }
            }
        }
    }
}
