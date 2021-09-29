using Lecture.Farming;
using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            Cow dairyCow = new Cow();
            Tractor johnDeere = new Tractor();
            Console.WriteLine(dairyCow.ToString());
            Console.WriteLine( johnDeere.ToString());
            //polymorphism
            //FarmAnimal[] animals = new FarmAnimal[] { new Cow(), new Chicken(), dairyCow , johnDeere };
            Pig porky = new Pig();
            ISing[] singers = new ISing[] { dairyCow, johnDeere, porky };
            
            //cant create an instance of interfaces
           // ISing sing = new ISing();

            FarmAnimal chicken = new Chicken();
            Chicken chicken2 = new Chicken();

            Object o = new Object();

            foreach (ISing singer in singers)
            {
            
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + singer.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + singer.MakeSound() + " " + singer.MakeSound() + " here");
                Console.WriteLine("And a " + singer.MakeSound() + " " + singer.MakeSound() + " there");
                Console.WriteLine("Here a " + singer.MakeSound() + " there a " + singer.MakeSound() + " everywhere a " + singer.MakeSound() + " " + singer.MakeSound());
                Console.WriteLine();
            }
        }
    }
}