/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        double C = double.Parse(Console.ReadLine());

        double areaTriangulo = (A * C) / 2.0;
        double areaCirculo = 3.14159 * C * C;
        double areaTrapezio = ((A + B) * C) / 2.0;
        double areaQuadrado = B * B;
        double areaRetangulo = A * B;

        Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
        Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
    }
}
