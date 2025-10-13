using System;

class Program{

    static void Main(string[] args)
    {
        try {
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for(int i = 0 ; i < n; i++)
        {

            string[] values = Console.ReadLine().Split(' ');

            for(int j = 0; j < n; j++)
            {

                mat[i,j] = int.Parse(values[j]);
            }
        }

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"[{mat[i, j]}] ");
            }
            Console.WriteLine();
        }
        } catch(Exception e) {
            Console.WriteLine("Deu erro");
        }
    }
}