using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    class Player
    {
    //    public enum GenderType()
    //    {
    //        MALE,FEMALE
    //}

         private string _name;
    //    private GenderType _gender;
        private int _age;

        public Player(String _name):this(_name,18)
        {
                          
        }
        public Player(String _name, int _age)
        {
            this._name = _name;
            this._age = _age;
        }
       // get age and name
       public String Name
        {
            get
                {
                   return this._name;
                }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
        }
        public Player  WhoIsElder(Player eld)
        {
            if (eld.Age > this._age)
                return eld;
            else
                return this;
        }
    }
}
