using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            char cont;
            int index = 0;

            Console.WriteLine("ToDo App:");
            do
            {
                Console.WriteLine("1.Display");
                Console.WriteLine("2.Add");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        if(al.Contains(null))
                        {
                            Console.WriteLine("List is empty.......");
                            break;
                        }
                        else
                        {
                            foreach(String a in al)
                                Console.WriteLine(a);
                                break;
                        }
                    case 2:
                        Console.WriteLine("Enter the element to add");
                       string temp = Console.ReadLine();
                        al.Add(temp);
                        break;

                    case 4:
                        break;

                    case 3:
                        Console.WriteLine("Element in list : ");
                        
                        for (int i = 0; i < al.Count; i++)
                            Console.WriteLine($"{i + 1} {al[i]}");

                        Console.WriteLine("Enter index of element to remove: ");
                        int element = Convert.ToInt32(Console.ReadLine());
                         al.RemoveAt(element-1);
                      
                        break;

                        
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont == 'Y' || cont == 'y');
            Console.ReadLine();

        }
    }
}
