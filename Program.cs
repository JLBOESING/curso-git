using System;
using System.Collections.Generic;
using System.Globalization;

namespace Empregado
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = DateTime.Now;

            string s1 = d.ToString("dd-MM-yyyy");
            Console.WriteLine(s1);

            DateTime x = d.AddDays(5);
            Console.WriteLine(x);
            
            Console.WriteLine("Quantos empregados serão registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

             for (int i = 1; i <= n; i++)
             {
                    Console.WriteLine("Employee #" + i + ":");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Employee(id, name, salary));
                    Console.WriteLine();
             }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
