using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1  = new Human("Amanda", 3, 3, 3, 100);
            Console.WriteLine($"I am {h1.Name} with a strength of {h1.Strength}, intelligence of {h1.Intelligence}, dexterity of{h1.Dexterity}, and health of {h1.health}");
            h1.Name = "Sarah";
            Console.WriteLine($"My name is {h1.Name}");
        }

        public class Human
    {
        //These are all the things/attributes to descibe the human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public int health {get{return Health;}}

// This is the constructor for the human class
        public Human(string name)
        {
            this.Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        //This is a constructor allowing to set custum values
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        //This is a method that allows the human to be attacked
        public int Attack(Human target)
        {
            int AttackValue = Strength *5;
            target.Health -= AttackValue;
            return target.health;
        }
    }
}
}
