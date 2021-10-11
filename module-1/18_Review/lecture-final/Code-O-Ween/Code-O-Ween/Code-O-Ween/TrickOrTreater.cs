using System;
using System.Collections.Generic;
using System.Text;

namespace Code_O_Ween
{
    public class TrickOrTreater : Kid, ICandyTaker
    {
        public List<string> Candy { get; set; } = new List<string>();

        public string Costume { get; }

        public TrickOrTreater(string name, int age, string costume) : base(name, age)
        {
            Costume = costume;
        }

        public string Trick()
        {
            string output;

            if (Age < 6)
            {
                output = "being cute";
            }
            else if (Age>=6 && Age < 13)
            {
                output = "flossing";
            }
            else
            {
                output = "a stinky surprise";
            }

            return output;
        }

        public string Treat()
        {
            return $" check out my {Costume}, candy please";
        }

        public override string SayGreeting()
        {
            return $"Trick or Trick I'm { Age } my trick is { Trick() } { Treat()} ";
        }
    }
}
