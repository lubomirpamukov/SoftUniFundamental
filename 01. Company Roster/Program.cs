namespace _01._Company_Roster
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employeeData = Console.ReadLine().Split(" ", StringSplitOptions.TrimEntries);
                string name = employeeData[0];
                decimal salary = decimal.Parse(employeeData[1]);
                string department = employeeData[2];

                Employee employee = new Employee(name, salary, department);
                list.Add(employee);
            }

            var highestSalaryDepartment = list.GroupBy(e => e.Department) // making temporari variable that groups the employyes by department
                                              .Select( g => new { // with select we make temporary object that have 2 properties
                                               Department = g.Key, // first property is the name of the department
                                               AvrageSalary = g.Average(e =>e.Salary)}) // secound property is the calculated avrage salary of the department
                                              .OrderByDescending(g => g.AvrageSalary) // ordering the list by decending order
                                              .First(); // tsking only the first object, the highest payed department

            Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment.Department}");

            foreach (Employee employee in list.Where(e => e.Department == highestSalaryDepartment.Department).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }

    public class Employee //creating a class employ
    {
        public Employee(string name, decimal salary, string department) //creating a constructor for the employee class
        {
            Name = name; // assinging value to the Name property
            Salary = salary; // assigning value to the Salary property
            Department = department;// assigning value to the Department property
        }
        public string Name { get; set; } // making Name property

        public decimal Salary { get; set; } // making Salary property

        public string Department { get; set; } // making department property

        public override string ToString() // overwriting the ToString method
        {
            return $"{Name} {Salary:f2}";
        }
    }
}