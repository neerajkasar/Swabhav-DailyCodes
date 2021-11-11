using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePolymorphism.Model;

namespace EmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "NK", 2000f);
            Manager manager = new Manager(1, "NK", 2000f);
            DisplaySalarySlip(manager);
            Developer developer = new Developer(1, "NK", 2000);
            DisplaySalarySlip(developer); 
            Accountant accountant = new Accountant(1, "NK", 2000);
            DisplaySalarySlip(accountant);  

            Console.ReadLine();

        }
        static void DisplaySalarySlip(Employee e)
        {
            Console.WriteLine($"Employee No: {e.EmployeeNo} Name: {e.Name} Salary: {e.Salary} ");
            Console.WriteLine(e.Calculate());
        }
    }
}
