using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FullName = "Иванов",
                Salary = 63500
            };

            employee.Show();

            decimal annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Годовая зарплата: {annualSalary} руб.");

            Console.ReadKey();

        }
    }
}
    class Employee
    {
    public string FullName { get; set; }
    public decimal Salary { get; set; }

    public void Show()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Зарплата: {Salary} руб.");
    }

    public decimal CalculateAnnualSalary()
    {
        return Salary * 12;
    }
    }
