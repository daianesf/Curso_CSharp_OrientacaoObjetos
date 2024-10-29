using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de pares:");
        int N = int.Parse(Console.ReadLine()); 
       
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o par de números {i + 1}:");
            string[] valores = Console.ReadLine().Split(' '); 

           
            double numerador = double.Parse(valores[0]);
            double denominador = double.Parse(valores[1]);

            if (denominador == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = numerador / denominador; 
                Console.WriteLine(resultado);
            }
        }
    }
}
