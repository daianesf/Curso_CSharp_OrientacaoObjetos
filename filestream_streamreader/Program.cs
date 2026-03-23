/* FileStream: Disponibiliza uma stream associada a um arquivo, permintindo
 operacoes de leitura e escrita.

Suporte a dados binários.

Instaciaçao: Varios construtores - File/FileInfo.

StreamReader : É uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream).

Suporte a dados no formato de texto.

read chars -> StreamReader -> FileStream -> file
*/

using System;
using System.IO;

namespace filestream_streamreader
{
    class Program
    {
        static void Main (string[] args)
        {
            string path = @"/Users/daiane/Documents/file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
           
            }

        }
    }
}