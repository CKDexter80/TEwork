using System;

namespace BattleSim
{
    class Program
    {
        static void Main(string[] args)
        {

            //interface on the left concrete type on the right
            //known as programming to an abstraction
            //ensures loosely coupled and TESTable code
            IFighter wereWolf = new WereWolf("Ork");
            IFighter teenWolf = new TeenWereWolf();

            //
            // we might consider creating Battle ground class
            // that would handle creating fighters and fighting the,
            //

            Console.WriteLine(teenWolf.ToString());
            Console.WriteLine(wereWolf.ToString());
            //IFighter guarantees we will have an attack method
            //polymorphically calling derived class' specialized attack method
            teenWolf.Attack(wereWolf);
            Console.WriteLine("Werewolf after being attacked");
            Console.WriteLine(wereWolf.ToString());
            
        }
    }
}
