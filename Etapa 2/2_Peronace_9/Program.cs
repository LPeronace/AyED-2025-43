namespace _2_Peronace_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas filas queres que tenga tu tabla?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas columnas queres que tenga tu tabla?");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Y de cuanto rango?");
            int rango = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();

            int[,] tabla = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    tabla[i, j] = aleatorio.Next(0, rango);
                    Console.WriteLine(tabla[i, j]);
                }
            }
        }
    }
}
