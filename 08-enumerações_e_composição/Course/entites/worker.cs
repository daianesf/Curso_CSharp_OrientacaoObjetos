using System.Collections.Generic;   
using Course.entites.Enums;
using Course.entites;

namespace Course.entites
{
    class Worker
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();
        public WorkerLevel Level1 { get; }

        public Worker()
        {
        }
        public Worker(string name, int level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Worker(string? name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level1 = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HoursContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }   
    }
}
