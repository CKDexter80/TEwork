using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class Wall
    {
        public Wall(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; }
        public string Color { get; }

        public abstract int GetArea();

        /*public override string ToString()
        {
            return $"{Name} ";
        }
        */


    }
}
