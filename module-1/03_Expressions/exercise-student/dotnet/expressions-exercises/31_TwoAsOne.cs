﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         TwoAsOne(1, 2, 3) → true
         TwoAsOne(3, 1, 2) → true
         TwoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)
        {
            if (a + b == c)
            {
                return true;
            } else if (a + c == b)
            {
                return true;
            } else if (b + c == a)
            {
                return true;
            }
           
            return false;
        }
    }
}
