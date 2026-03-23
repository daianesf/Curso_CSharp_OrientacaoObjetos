using System;
using ExercicioFixacao.Entities;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main (string[] args)
        {
            //Ler arquivo
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine()!.Trim();

            List<Employee> list = new List<Employee>();

             using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()!;
                    string[] fields = line.Split(',');

                        if (fields.Length < 3)
                        {
                            Console.WriteLine("Linha inválida: " + line);
                            continue;
                        }
                    string name = fields[0];
                    string email = fields[1];
                    double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee (name, email, salario));
                }

                //  Mostrar todos os funcionários ordenados por nome
                var loa = list
                .OrderBy(p => p.Name);

                foreach (Employee p in loa)
                {
                    Console.WriteLine(p.Name + ", " + p.Email + ", " 
                    + p.Salario.ToString("F2", CultureInfo.InvariantCulture));
                }

             }

             //iltrar emails por salário informado
             Console.WriteLine("Enter salary to filter emails:");
             double Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

             Console.WriteLine("Email of people whose salary is more than" + Salary + ":");

             var Sal = list
             .Where(p => p.Salario > Salary)
             .OrderBy(p => p.Email)
             .Select(p => p.Email)
             ;

             foreach (string email in Sal)
            {
                Console.WriteLine(email);
            }

            // Soma dos salários de funcionários cujo nome começa com 'M'
            var Msoma = list
            .Where(p => p.Name.StartsWith("M", StringComparison.OrdinalIgnoreCase))
            .Sum(p => p.Salario);

            Console.WriteLine("Sum of salaries of employees whose names begin with 'M': " 
             + Msoma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}