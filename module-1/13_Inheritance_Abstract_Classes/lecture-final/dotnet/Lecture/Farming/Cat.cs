using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{//final form cannot be inherited from
    public sealed class Cat : FarmAnimal
    {
        public Cat() : base("cat", "meow")
        {

        }

        public override string MakeSound()
        {//todo
            throw new NotImplementedException();
        }
    }
}
