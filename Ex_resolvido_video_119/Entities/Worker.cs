using Ex_resolvido_video_119.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Ex_resolvido_video_119.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        
        //fazendo a associação entre dois objetos: composição
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Usamos uma lista porque um trabalhador tem vários contatos
        //Já instânciamos para garantir que ela não é vazia

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            //Sempre que houver uma associação para muitos não devemos inseri-la no construtor
        }
        

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (var item in Contracts)
            {
                if (item.Date.Year==year && item.Date.Month==month)
                {
                    sum += item.TotalValue(); 
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return "Name: "
                   +Name
                   +"\nDepartment: "
                   +Department;
        }
    }
}
        