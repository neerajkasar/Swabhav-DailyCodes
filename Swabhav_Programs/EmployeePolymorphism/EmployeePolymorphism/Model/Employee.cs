using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    class Employee
    {
        private int _employeeNo;
        private String _name;
        private double _salary;

        public Employee(int employeeNo, String name, double salary)
        {
            _employeeNo = employeeNo;
            _name = name;
            _salary = salary;
        }

        public int EmployeeNo
        {
            get
            {
                return _employeeNo;
            }
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }
        public void Calculate()
        {

        }
        
    }
}
