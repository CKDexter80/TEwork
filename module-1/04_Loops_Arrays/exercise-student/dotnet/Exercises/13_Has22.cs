﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         Has22([1, 2, 2]) → true
         Has22([1, 2, 1, 2]) → false
         Has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {

            int arrayLength = nums.Length;
            int twoCounter = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (nums[i] == 2)
                {
                    twoCounter++;
                }
                else
                {
                    twoCounter = 0;
                }

                if (twoCounter == 2)
                {
                    return true;
                }
            }
            return false;
           
        }
    }
}
