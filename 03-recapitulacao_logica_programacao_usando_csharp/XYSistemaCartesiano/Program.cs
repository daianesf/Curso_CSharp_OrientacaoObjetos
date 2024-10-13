/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)*/

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite as coordenadas X e Y (separadas por espaço): ");
            string entrada = Console.ReadLine();

            // Divide a entrada em partes e tenta convertê-las para double
            string[] coordenadas = entrada.Split(' ');
            if (coordenadas.Length < 2) continue; // Ignora se a entrada não tem duas partes

            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            // Verifica se alguma coordenada é nula
            if (x == 0 || y == 0)
            {
                break; // Encerra o loop se alguma coordenada for zero
            }
         
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else // (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
        }
    }
}