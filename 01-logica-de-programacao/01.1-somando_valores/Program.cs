using System;

namespace somando_valores
{
    class Program
    {
        static void Main(string[] args) 
        {
            int peça1, quantidade1;
            double valor1, tot1;

            Console.WriteLine("Digite o código da peça1:");
            peça1 = int.Parse(Console.ReadLine() ?? "0");
                  

            Console.WriteLine("Digite a quantidade de peças1:");
            quantidade1 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o valor unitário da peça1:");
            valor1 = double.Parse(Console.ReadLine() ?? "0");

            tot1 = quantidade1 * valor1;           


            int peça2, quantidade2;
            double valor2, tot2;

            Console.WriteLine("Digite o código da peça2:");
            peça2 = int.Parse(Console.ReadLine() ?? "0");
                  

            Console.WriteLine("Digite a quantidade de peças2:");
            quantidade2 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o valor unitário da peça2:");
            valor2 = double.Parse(Console.ReadLine() ?? "0");

            tot2 = quantidade2 * valor2;

            Console.WriteLine($"O valor a pagar é {tot2+tot1:F2}");
        }
    }
}