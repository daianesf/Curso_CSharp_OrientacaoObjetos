using System;

namespace ExercicioFixacao.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public double Salario { get; set; }


        public Employee (string name, string email ,double salario)
        {
            Name = name;
            Email= email;
            Salario = salario;
        }
    }
}