using System;
using System.Collections.Generic;
using System.Linq;

class CompanyRoster
{
    static void Main()
    {
        var company = new Dictionary<string, List<Employee>>();
        var employeeCount = int.Parse(Console.ReadLine());
        for (int counter = 0; counter < employeeCount; counter++)
        {
            var employeeData = Console.ReadLine().Split();
            var dataCount = employeeData.Length;
            var name = employeeData[0];
            var salary = decimal.Parse(employeeData[1]);
            var position = employeeData[2];
            var department = employeeData[3];
            var email = "n/a";
            var age = -1;
            if (dataCount == 5)
            {
                if (!int.TryParse(employeeData[4], out age))
                {
                    email = employeeData[4];
                    age = -1;
                }
            }

            if (dataCount == 6)
            {
                email = employeeData[4];
                age = int.Parse(employeeData[5]);
            }
            var empployee = new Employee(name, salary, position, department, email, age);
            if (!company.ContainsKey(department))
            {
                company[department] = new List<Employee>();
            }
            company[department].Add(empployee);
        }

        foreach (KeyValuePair<string, List<Employee>> kvp in company.OrderByDescending(y => y.Value.Sum(x => x.Salary) / y.Value.Count))
        {
            Console.WriteLine($"Highest Average Salary: {kvp.Key}");
            foreach (Employee employee  in kvp.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(employee);
            }
            break;
        }
    }
}