using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSim
{
    //inherits from base abstract class 'Fighter' implements ITakeDamage --DecreaseHealth Method
    public class WereWolf : Fighter
    {

        //Werewolf specific strength - used for attacking
        public override int Strength { get; } = 100;
        //since The fighter class constructor is overloaded we must explicitly call base(name) and pass a string
        public WereWolf(string wereWolfName) : base(wereWolfName)
        {
           
        }

        //base class defined as abstract method which we must implement in any derived class
        //ITakeDamage is an abstraction describing but not implementing what it means to be
        //'Attackable' and decrease health by our class Strength
        public override void Attack(ITakeDamage victim)
        {
            victim.DecreaseHealth(Strength);
        }
    }
}
