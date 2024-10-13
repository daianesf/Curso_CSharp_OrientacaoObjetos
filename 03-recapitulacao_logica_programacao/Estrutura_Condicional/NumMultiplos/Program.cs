/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um Numero A: ");
        int NumDigitadoA = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite um Numero B: ");
        int NumDigitadoB = int.Parse(Console.ReadLine() ?? "0");

        if (NumDigitadoB != 0)
        {

            if (NumDigitadoA % NumDigitadoB == 0)
            {
                Console.Write("É multiplo!");
            }
            else
            {
                Console.Write("Não é Multiplo!");
            }
        }
        else
        {
            Console.WriteLine("Não é possível verificar múltiplos com o número zero.");
        }
    }
}