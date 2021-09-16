﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a non-negative number "num", return true if num is within 2 of a multiple of 10. Note: (a % b)
         is the remainder of dividing a by b, so (7 % 5) is 2.
         NearTen(12) → true
         NearTen(17) → false
         NearTen(19) → true
         */
        public bool NearTen(int num)
        {
            if ((num - 1) % 10 == 0 || (num-2) % 10 == 0 || (num + 1) % 10 == 0 || (num + 2) % 10 == 0 || num % 10 == 0)
                {
                    return true;
                }
            return false; //This code is so sweaty. I'm sorry;
            
        }
    }
}