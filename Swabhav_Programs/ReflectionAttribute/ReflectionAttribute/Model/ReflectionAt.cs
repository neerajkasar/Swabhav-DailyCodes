using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionAttribute.Model;

namespace ReflectionAttribute.Model
{
    class ReflectionAt : Attribute
    {
        private Animals _pet;
     public  ReflectionAt()
        {
          
        }
        
        public Animals pet
        {
            get
            {
                return _pet;
            }
            set
            {
                _pet = pet;
            }
        }
    }

}
