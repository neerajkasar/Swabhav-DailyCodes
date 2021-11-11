using System;

namespace HelloWorldApp
{
    class Player
    {
        public string name = "Neeraj";
        public int health = 45;
        public int setHealth(int heal)
        {
            health = heal;
            return health;
        }
    }
    class Assaulter: Player
    {
        int finishes = 41;
        
    }
}
