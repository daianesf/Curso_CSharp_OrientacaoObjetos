/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Que Horas iniciou: ");
        int inicioJogo = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Que Horas acabou?: ");
        int TerminoJogo = int.Parse(Console.ReadLine() ?? "0");

        if (inicioJogo < 0 || inicioJogo > 23 || TerminoJogo < 0 || TerminoJogo > 23)
        {
            Console.WriteLine("Horas inválidas! As horas devem estar entre 0 e 23.");
            return;
        }

        int duracao;
        
        if (TerminoJogo > inicioJogo)
        {
            duracao = TerminoJogo - inicioJogo;
        }
        else
        {
            // O jogo terminou no dia seguinte
            duracao = (24 - inicioJogo) + TerminoJogo;
        }

        Console.WriteLine($"DURAÇÃO DO JOGO: {duracao} horas");
    }
}