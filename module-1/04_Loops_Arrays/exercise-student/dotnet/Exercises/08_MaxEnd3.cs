namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements
         in the array, and set all the other elements to be that value. Return the changed array.
         MaxEnd3([1, 2, 3]) → [3, 3, 3]
         MaxEnd3([11, 5, 9]) → [11, 11, 11]
         MaxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int arrayLast = nums.Length - 1;
            int arrayLength = nums.Length;
            int largestValue = 0;
            int[] maxArray = new int[arrayLength];

            if (nums[0] > nums[arrayLast])
            {
                largestValue = nums[0];

            } else largestValue = nums[arrayLast];

            for (int i = 0; i < arrayLength; i++)
            {
                maxArray[i] = largestValue;
            }
            return maxArray;
        }
    }
}
