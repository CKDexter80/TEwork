using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISell
    {
        //public override string Name { get; }
        public Chicken(string name) : base(name, "cluck")
        {
          //  Name = name;
        }

        public decimal Price { get; } = 5M;

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }

        public override string MakeSound()
        {
            return "cluck";
        }

    }
}
