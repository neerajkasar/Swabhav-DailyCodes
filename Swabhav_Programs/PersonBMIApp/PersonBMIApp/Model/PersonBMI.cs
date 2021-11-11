using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace PersonBMIApp.Model
{
    class PersonBMI
    {
        private int _age, _weight;
        private float _height;
        private string _gender,_st;
        private float _bmi;

        public PersonBMI(float height ,int weight, int age, string gender)
        {
            _height = height;
            _weight = weight;
            _age = age;
            _gender = gender;
        }
        
        public float BMIScore()
        {
            return _weight / (_height * _height);
        }
        public void Workout()
        {
            _weight = _weight % 10;
        }
        public String BodyStructure()
        {
            if (_bmi > 18.5)
                return  "Overweight";
            if (_bmi < 18.5)
                return "Underweight";
            else return  "fit";
        }
        public void eat()
        {
            _height = _height + ((_height % 100) * 2);
            _weight = _weight - _weight % 10;
        }

        public float GetHeight()
        {
            return _height;
        }
        public int GetWeight()
        {
            return _weight;
        }
        public int GetAge()
        {
            return _age;
        }
        public String GetGender()
        {
            return _gender;
        }
        
    }
}
