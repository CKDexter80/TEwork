using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISing, IMow
    {

        public string Name { get; } = "bert";
        public string MakeSound()
        {
            return "vroom";
        }

        public void Mow()
        {
            Console.WriteLine("mowing ensues");
        }
        
    }
}
