using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int n1 = int.Parse(Console.ReadLine() ?? "0");

        if (n1 % 2 == 0)
        {
            Console.WriteLine("par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }

}