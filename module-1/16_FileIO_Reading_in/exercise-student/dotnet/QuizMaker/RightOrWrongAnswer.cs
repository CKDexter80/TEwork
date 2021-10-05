using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class RightOrWrongAnswer
    {
        public static int RightOrWrong(string expected, string actual)
        {

            if (expected == actual)
            {
                Console.WriteLine($"RIGHT!");
                return 1;
                
            }
            else
            {
                Console.WriteLine($"WRONG!");
                return 0;
            }
        }
    }
}
