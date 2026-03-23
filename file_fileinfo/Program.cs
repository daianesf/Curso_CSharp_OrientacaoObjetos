using System;
using System.IO;

namespace file_fileinfo
{
    class Program
    {

        static void Main(string[] args)
        {

            string sourcePath = @"/Users/daiane/Documents/file1.txt";
            string targetPath = @"/Users/daiane/Documents/file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
