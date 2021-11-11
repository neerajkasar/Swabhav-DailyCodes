using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp.Model;
namespace InheritanceApp.Model
{
    class Kid : Man
    {
        public override void Play()
        {
            Console.WriteLine("Kid is playing");
            //base.Play();
        }
    }
}
