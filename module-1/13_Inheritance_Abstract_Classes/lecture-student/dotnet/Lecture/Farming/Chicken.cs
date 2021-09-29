using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISellable
    {
        public Chicken() : base("Chicken", "cluck")
        {
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
