/*
using block: Sintaxe simplificada que garante que os objetos IDiponibke serao fechados.

Objetos IDisposable nao sao gerenciados pelo CLR. Eles precisam ser manualmente fechados.
Ex: Font, FileStream, StreamReader, StreamWriter
*/

using System;
using System.IO;

namespace usingblock
{
    class Program{
        static void Main(string[] args)     
        {
            string path = @"/Users/daiane/Documents/file1.txt";
            
            try{
            
            
            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occuted");
                Console.WriteLine(e.Message);
            }

        }
    }
}
