using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISing, IMow
    {
        public string Name { get; } = "Bertha";

        public string MakeSound()
        {
            return "vrroooomm";
        }

        public void Mow()
        {
            Console.WriteLine("mowing ensues");
        }
        public override string ToString()
        {
            return "Hello from overridden method";
        }
    }
}
