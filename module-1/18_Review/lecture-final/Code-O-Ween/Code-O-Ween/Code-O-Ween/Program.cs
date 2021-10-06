using System;
using System.Collections.Generic;

namespace Code_O_Ween
{
    class Program
    {
        static void Main(string[] args)
        {

            TrickOrTreater kidA = new TrickOrTreater("Luca", 9, "LazerBeam");
            TrickOrTreater kidB = new TrickOrTreater("Nicola", 6, "SniperWolf");
            TrickOrTreater kidC = new TrickOrTreater("MeInDisguise", 14, "MasterChief");

            List<TrickOrTreater> kids = new List<TrickOrTreater>() { kidA, kidB };

            foreach (TrickOrTreater kid in kids)
            {
                Console.WriteLine(kid.SayGreeting());
            }

            Console.WriteLine("Hello World!");
        }
    }
}
