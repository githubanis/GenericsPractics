using System;
using System.Collections.Generic;

namespace GenericsPractics
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeByDepertment = new SortedDictionary<string, List<Employee>>();

            employeeByDepertment.Add("Sales",
                    new List<Employee> { new Employee(), new Employee(), new Employee()}
                );
            employeeByDepertment.Add("Engineering",
                    new List<Employee> { new Employee(), new Employee() }
                );
            foreach (var item in employeeByDepertment)
            {
                Console.WriteLine($"The number of employee in the {item.Key} Depertment is: {item.Value.Count}");
            }
        }
    }
}
