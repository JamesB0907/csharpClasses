using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get ; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();    
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void EmployeeList()
        {
            foreach (Employee employee in Employees)
            {
                string startDate = employee.StartDate.ToString("m/d/yy");
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for Overlord, Co. as a {employee.Title} since {employee.StartDate}");
            }
        }
        
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}