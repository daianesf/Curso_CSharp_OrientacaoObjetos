﻿using System;

namespace PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
           
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine() ?? "0";
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine()?? "0");
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine() ?? "0";
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine() ?? "0");

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}