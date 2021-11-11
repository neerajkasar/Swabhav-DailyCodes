using System;

namespace DotComGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the index of number: ");
            int count = 0 , guess;
            int []  ary = new int[] {0,0,1,1,1,0,0,0};
            //                       0 1 2 3 4 5 6 7
            while(ary[2] != 0 || ary[3] != 0 || ary[4] != 0)
            {
                Console.WriteLine("Guess: ");
                 guess = Convert.ToInt32(Console.ReadLine());
                count += 1;
                if (ary[guess] == 1)
                {
                    Console.WriteLine("Hit");
                    ary[guess] = 0;
                }
                else if (ary[guess] == 0)
                    Console.WriteLine("Miss");
            }
            if(ary[2] == 0 && ary[3] == 0 && ary[4] == 0)            
                Console.WriteLine($"You guessed in {count} steps");
            
            Console.ReadLine();
        }
    }
}
