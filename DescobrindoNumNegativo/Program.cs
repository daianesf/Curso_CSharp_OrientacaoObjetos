/*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um Numero: ");
        int NumDigitado = int.Parse(Console.ReadLine() ?? "0");

        if(NumDigitado < 0)
        {
            Console.Write(" Número Negativo!");
        } else
        {
            Console.Write("Numero Não Negativo!");
        }
    }
}