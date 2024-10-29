using System;


    public class Estudante 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudante(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

    }

    public class Program 
    {
        public static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for( int i=0; i<n; i++){
                Console.Write($"\nAluguel#{i+1}:");

                Console.Write("\nNome completo: ");
                string nome = Console.ReadLine();

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();

                Console.Write("\nQuarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Estudante(nome, email, quarto);
            }

            Console.WriteLine("\nQuartos Ocupados:");
            for(int i=0; i < 10; i++){
                if (quartos[i] != null){
                    Console.WriteLine($"{i} : {quartos[i].Nome}, {quartos[i].Email}\n");
                }
            }
        }
    }





