using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

       
        int soma = numero1 + numero2;

        
        Console.WriteLine($"A soma de {numero1} e {numero2} é {soma}.");
    }
}
