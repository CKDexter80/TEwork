using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSim
{
    public class TeenWereWolf : WereWolf
    {
        //Teen wolf not as strong, everything else is the same
        public override int Strength { get; } = 90;
        public TeenWereWolf() : base("Teen Wolf")
        {

        }
    }
}
