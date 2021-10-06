using System;
using System.Collections.Generic;
using System.Text;

namespace Code_O_Ween
{
    public abstract class Kid
    {
        public string Name { get; }
        public int Age { get; }
        public Kid(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string SayGreeting()
        {
            return $"Hi, my name is {Name}, I'm {Age} years old";
        }
    }
}
