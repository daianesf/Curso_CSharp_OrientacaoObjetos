﻿/*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
duas casas decimais*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário: R$ ");
        double salario = double.Parse(Console.ReadLine());

        double imposto = 0.0;

        if (salario <= 2000.00)
        {
            imposto = 0.0; // Isento
        }
        else if (salario <= 3000.00)
        {
            imposto = (salario - 2000.00) * 0.08; // 8% sobre o que ultrapassa R$ 2000
        }
        else if (salario <= 4500.00)
        {
            imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18); // 8% sobre R$ 1000 + 18% sobre o que ultrapassa R$ 3000
        }
        else
        {
            imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28); // 8% sobre R$ 1000 + 18% sobre R$ 1500 + 28% sobre o que ultrapassa R$ 4500
        }

        Console.WriteLine($"Imposto a pagar: R$ {imposto:F2}");
    }
}