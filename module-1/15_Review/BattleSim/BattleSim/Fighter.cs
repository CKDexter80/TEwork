using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSim
{
    public abstract class Fighter : IFighter
    {
        //name can only be set in this class
        public string Name { get; }
        //this and derived classes are able to set the Health
        public int Health { get; private set; } = 100;
        //derived classes must set Strength
        public abstract int Strength { get; }
        //All Fighters need a name if none given as a constructor parameter, set a default
        public Fighter()
        {
            Name = "goon who shall not be named";
        }
        //overloading constructor, giving a 2nd way to create an instance
        public Fighter(string name)
        {
            Name = name;
        }
        // all fighters must implement their specializedAttack
        // can only be called against objects that implement ITakeDamage
        public abstract void Attack(ITakeDamage victim);
        //all derived classed share Decrease health method(cannot be overridden)
        public void DecreaseHealth(int damage)
        {
            Health -= damage;
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            return $"I am a {type}, my name is {Name}. Health is {Health}";
        }
    }
}
