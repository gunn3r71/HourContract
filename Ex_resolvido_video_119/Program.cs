using Ex_resolvido_video_119.Entities;
using Ex_resolvido_video_119.Entities.Enums;
using System;
using System.Globalization;

namespace Ex_resolvido_video_119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Now enter worker data: ");
            Console.Write(" Enter worker name: ");
            string workerName = Console.ReadLine();

            Console.Write(" Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write(" Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker( workerName, level, baseSalary, new Department(department));

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the {i}# contract data: ");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date,valuePerHour,duration));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime date_c = DateTime.ParseExact(Console.ReadLine(),"MM/yyyy",CultureInfo.InvariantCulture);
            
            Console.WriteLine($"{worker}\nIncome for {date_c:MM/yyyy}: {worker.Income(date_c.Year,date_c.Month).ToString("F2",CultureInfo.InvariantCulture)}");
            
        }
    }
}
