using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pig : FarmAnimal
    {

        public Pig() :  base("pig", "oink")
        {
                
        }

        public override string MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
