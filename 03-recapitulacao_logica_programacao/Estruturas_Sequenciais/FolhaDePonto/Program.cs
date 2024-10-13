/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais*/

using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numero, horas;
        double valorHora, salario;

        Console.Write("Digite o numero do funcionario: ");
        numero = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite as horas trabalhadas: ");
        horas = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("O valor da hora trabalhada:");
        valorHora = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

        salario = valorHora * horas;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}

