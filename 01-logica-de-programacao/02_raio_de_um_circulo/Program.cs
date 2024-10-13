using System;

namespace raio_de_um_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159; 
            double raio, area;

            Console.WriteLine("Digite o valor do raio do círculo:");
            raio = double.Parse(Console.ReadLine() ?? "0"); 
            area = pi * Math.Pow(raio, 2); 

            
            Console.WriteLine($"A área do círculo é: {area:F4}");
        }
    }
}