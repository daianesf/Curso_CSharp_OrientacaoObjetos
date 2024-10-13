using System;

class Program
{
    static void Main(string[] args)
    {
        int voto = 0;
        int gasolina = 0;
        int etanol = 0;
        int diesel = 0;

        while (voto != 4)
        {
            Console.Write("Digite uma opção: ");
            voto = int.Parse(Console.ReadLine() ?? "4");

            switch (voto)
            {
                case 1:
                    // Gasolina
                    gasolina++;
                    break;
                case 2:
                    // Etanol
                    etanol++;
                    break;
                case 3:
                    // Diesel
                    diesel++;
                    break;
            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {etanol}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}