/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de D: ");
        int D = Convert.ToInt32(Console.ReadLine());

        int DIFERENCA = (A * B) - (C * D);

        Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }
}