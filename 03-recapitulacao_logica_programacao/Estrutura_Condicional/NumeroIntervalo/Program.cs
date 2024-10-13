using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(num <=0|| num >=100){
            Console.WriteLine("Fora do Intervalo");
        }
        else if(num <= 0.25 )
        {
            Console.WriteLine("Intervalo 0,25");
        }else if(num <= 25.50)
        {
            Console.WriteLine("Intervalo 25,50");
        }else if (num <= 50.75)
        {
            Console.WriteLine("Intervalo 50,75");

        }else if(num <= 75.100)
        {
            Console.WriteLine("Intervalo 75,100");

        }
    }
}
