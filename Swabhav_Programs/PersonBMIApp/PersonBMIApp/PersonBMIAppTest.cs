using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonBMIApp.Model;

namespace PersonBMIApp
{
    class PersonBMIAppTest
    {
        static void Main(string[] args)
        {
            PersonBMI[] ob = new PersonBMI[3];
  //                              height weight age gender f: wight/h
            ob[0] = new PersonBMI(1.0f, 4,22, "Male");
            ob[1] = new PersonBMI(5.5f,12,33, "Female");
            ob[2] = new PersonBMI(3.5f,33,12, "Male");
            
            PrintBMI(ob);

            ob[1].eat();
            ob[2].Workout();
            //            ob[3].eat();
            Console.WriteLine("========After eat/workout==========");
            PrintBMI(ob);
            Console.Read();
        }
        static void PrintBMI(PersonBMI [] print)
        {
            for(int i = 0; i<print.Length;i++)
            {
                Console.WriteLine($"Person{i}:: height : {print[i].GetHeight()}  Weight : {print[i].GetWeight()}  Age: {print[i].GetAge()} Gender: {print[i].GetGender()} BMI: {print[i].BMIScore()} Structure: {print[i].BodyStructure()}");
            }
        }
    }
}
