using System;

 class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a quantidade de Numeros: ");
            int n = int.Parse(Console.ReadLine()??"0");

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite o valor {i + 1}:");
                int x = int.Parse(Console.ReadLine()?? "0");

                if (x >= 10 && x <= 20) {
                    cont_in = cont_in + 1;
                }
                else {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }