﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given three int values, a b c, return the largest.
        IntMax(1, 2, 3) → 3
        IntMax(1, 3, 2) → 3
        IntMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            int largestNumber = 0;
            
            if (a > b)
            {
                largestNumber = a;
            } else
            {
                largestNumber = b;
            }
            
            if (largestNumber < c)
            {
                largestNumber = c;
            } 

         
            return largestNumber;
        }
    }
}