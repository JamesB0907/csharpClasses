using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Overlord Co.", new DateTime(2000, 1, 1));
            // Create three employees
            Employee employee1 = new Employee("James", "Brooks", "Overlord", new DateTime(1988, 09, 07));
            Employee employee2 = new Employee("Minion", "One", "Underling",  new DateTime(2000, 01, 01));
            Employee employee3 = new Employee("Minon", "Two", "Henchman", new DateTime(2021, 01, 01));
            // Assign the employees to the company
            
                    company.AddEmployee(employee1);
                    company.AddEmployee(employee2);
                    company.AddEmployee(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.EmployeeList();
        }
    }
}