using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    class Developer:Employee
    {
        private int _salary = 15000;
        public Developer(int employeeNo, String name, double salary): base(employeeNo,name,salary)
        {
          
        }
        public float PA()
        {
            return ((_salary / 2) - (_salary / 10));
        }
        public float OT()
        {
            return ((_salary / 2) - ((_salary / 10) + (_salary / 10)));
        }
        public void Calculate()
        {
            Console.WriteLine($"PA: {PA()} OT: {OT()} ");
        }
    }
}
