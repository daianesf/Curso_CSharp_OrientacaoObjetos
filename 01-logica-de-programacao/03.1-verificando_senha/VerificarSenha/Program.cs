using  System;

namespace VerificarSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string SenhaCorreta = "2002";
            int tentativas = 4;

            for(int i = 0; i < tentativas; i++)
            {
                Console.WriteLine("Digite sua senha:");
                string senhaDigitada = Console.ReadLine() ?? "0";

                if(senhaDigitada == SenhaCorreta){
                    Console.WriteLine("Acesso Permitido"); break;
                } else
                {
                    Console.WriteLine("Senha incorreta");
                }

                if( i == tentativas -1)
                {
                    Console.WriteLine("Número maáximo de tentativas alcançado. Acesso bloqueado!");
                }
            }           
        }
    }    
}
