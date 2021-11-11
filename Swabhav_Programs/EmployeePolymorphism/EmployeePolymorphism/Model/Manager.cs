using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    class Manager:Employee
    {
        private int _salary = 25000;
       public Manager(int employee, String name, double salary):base(employee, name, salary)
        {

        }
        public float HRA()
        {
            return (_salary / 2);
        }

        public float TA()
        {
            return ((_salary / 2) - (_salary / 10));
        }

        public float DA()
        {
            return ((_salary / 2) - ((_salary / 10) + (_salary / 10)));
        }
        public void Calculate()
        {
            Console.WriteLine($"HRA : {HRA()} TA: {TA()} DA:{DA()}");
        }
    }
}
