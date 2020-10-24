using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GenericsPractics
{
    public class EmployeeCompare : IEqualityComparer<Employee> , IComparer<Employee>
    {
        int IComparer<Employee>.Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }

        bool IEqualityComparer<Employee>.Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        int IEqualityComparer<Employee>.GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    internal class DepartmentCollection : SortedDictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(string departmentName, Employee employee)
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Employee>(new EmployeeCompare()));
            }
            this[departmentName].Add(employee);
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var department = new DepartmentCollection(); 

            department.Add("Sales", new Employee { Name = "Joy" })
                      .Add("Sales", new Employee { Name = "Jony" })
                      .Add("Sales", new Employee { Name = "Anis" })
                      .Add("Sales", new Employee { Name = "Anis" })
                      .Add("Sales", new Employee { Name = "Joy" });

            department.Add("Engineering", new Employee { Name = "Dani" })
                      .Add("Engineering", new Employee { Name = "Dani" })
                      .Add("Engineering", new Employee { Name = "Anis" })
                      .Add("Engineering", new Employee { Name = "Anis" })
                      .Add("Engineering", new Employee { Name = "Anis" });

            foreach (var depertment in department)
            {
                Console.WriteLine(depertment.Key);
                foreach (var employee in depertment.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                    //Console.WriteLine("\t" + employee.Age);
                }
            }
        }

    }
}