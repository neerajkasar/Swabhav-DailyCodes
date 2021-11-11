using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Model
{
    class Student
    {
        private int _roll;
        private string _name;
        private string _location;
        private int _std;
        public Student (int roll, int std, string location)
        {
            _roll = roll;
            _std = std;
            //_name = name;
            _location = location;
        }
        public override bool Equals(object obj)
        {
            var studObj = (Student)obj;
            if (this._roll == studObj._roll && this._std == studObj._std) return true;
            return false;
            
        }
        public override int GetHashCode()
        {
            return _roll;
        }
    }
}
