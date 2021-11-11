using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp.Model;

namespace InheritanceApp.Model
{
    class Boy: Man
    {
        public void Play()
        {
            Console.WriteLine("Boy is playing");
        }
        public void Jump()
        {
            Console.WriteLine("Boy is Jumping");
        }

    }
}
