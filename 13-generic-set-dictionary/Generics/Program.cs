using System;

namespace Generics
{
    class Program
    {
        static void Main (string [] agrs)
        {
            PrintServices<int> printServices = new PrintServices<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine()!);

            for(int i = 0 ; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine()!);
                printServices.AddValue(x);
            }
            int a = printServices.First();
            int b = a + 2;
            Console.WriteLine(a + " + 2 = " + b);

            printServices.Print();
            Console.WriteLine("First: " + printServices.First());

        }
    }
}