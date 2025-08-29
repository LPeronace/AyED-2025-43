using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        // TODO: implementar
        int vecinos = 0;
        if(row-1 >= 0)
        {
            if (grid[row-1,col] == 1)
            {
                vecinos += 1;

            }
        }
        if(col-1 >= 0)
        {
            if (grid[row,col-1] == 1)
            {
                vecinos += 1;
            }
        }
        if (row+1 < grid.GetLength(0))
        {
            if (grid[row+1,col] == 1)
            {
                vecinos += 1;
            }
        }
        if (col+1 < grid.GetLength(1))
        {
            if (grid[row, col + 1] == 1)
            {
                vecinos += 1;
            }                
        }
            // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
            // Devolver cuántos valen 1
        return vecinos; // <- reemplazar por tu solución
    }
}