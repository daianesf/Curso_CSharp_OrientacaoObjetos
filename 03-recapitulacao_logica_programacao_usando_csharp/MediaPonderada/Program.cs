/*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de casos de teste: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite os valores para o caso de teste {i + 1} (3 valores com uma casa decimal): ");
            string[] valores = Console.ReadLine().Split(' ');

            // Conversão dos valores para double
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);

            // Cálculo da média ponderada
            double mediaPonderada = (A * 2 + B * 3 + C * 5) / (2 + 3 + 5);

            // Exibe a média com uma casa decimal
            Console.WriteLine($"{mediaPonderada:F1}");
        }
    } 

}