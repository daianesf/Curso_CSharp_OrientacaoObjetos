/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159*/

using System;

class Program
{
    static void Main()
    {
       
        const double pi = 3.14159;

        Console.Write("Digite o valor do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = pi * Math.Pow(raio, 2);

        Console.WriteLine($"A = {area:F4}");
    }
}