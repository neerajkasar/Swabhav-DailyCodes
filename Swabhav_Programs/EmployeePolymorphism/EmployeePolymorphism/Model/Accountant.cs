using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    class Accountant:Employee
    {
        private int _salary = 10000;
        public Accountant(int employeeNo, String name, double salary) :base(employeeNo, name, salary)
        {

        }
        public float Perks()
        {
            return ((_salary / 2) - ((_salary / 10) + (_salary / 10)));
        }
        public void Calculate()
        {
            Console.WriteLine($"Perks: {Perks()}");
        }
    }
}
