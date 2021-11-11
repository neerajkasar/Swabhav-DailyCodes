using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsetApp.Model
{
    class Student
    {
        private int _roll;
        private string _name;
        private string _location;

        public Student (int roll,string name, string locaion)
        {
            _roll = roll;
            _name = name;
            _location = locaion;
        }
        public Student()
        {

        }
        public override int GetHashCode()
        {
            return _roll;
        }
        public override bool Equals(object obj)
        {
            Student studObj = (Student)obj;
            if (this._roll == studObj._roll) return true;
            return false;
           
        }
    }
}
