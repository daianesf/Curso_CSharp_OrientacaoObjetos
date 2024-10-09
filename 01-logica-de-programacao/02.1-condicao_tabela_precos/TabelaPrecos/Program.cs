using System;

namespace TabelaPrecos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] precos = {4.0, 4.50, 5.00, 2.00, 1.50};

            Console.Write("Digite o código do item: ");
            int CodigoItem = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine() ?? "0");

            double total = 0;

            switch (CodigoItem)
            {
                case 1:
                    total = precos[0] * quantidade;
                    Console.WriteLine("Cachorro Quente");
                    break;
                case 2:
                    total = precos[1] * quantidade;
                    Console.WriteLine(" X - salada");
                    break;
                case 3:
                    total = precos[2] * quantidade;
                    Console.WriteLine(" x - bacon");
                    break;
                case 4: 
                    total = precos[3] * quantidade;
                    Console.WriteLine(" torrada simples");
                    break;
                case 5:
                    total = precos[4] * quantidade;
                    Console.WriteLine(" refrigerante");
                    break;
                default: 
                    Console.WriteLine("Essa opção não existe");
                    return;
            }

            Console.WriteLine($"total: R$ {total:f2}");
        }
    }   
}