/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
X, se for o caso.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor entre 1 e 100: ");
        int X = int.Parse(Console.ReadLine() ?? "0");

        if (X < 1 || X > 100)
        {
            Console.WriteLine("Valor fora do intervalo permitido.");
            return;
        }

        for(int i = 1; i <= X; i++){
            if(i%2 != 0){
                Console.WriteLine($"{i} impar");
            }
        }
    }
}