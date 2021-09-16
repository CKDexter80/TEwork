namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if 6 appears as either the first or last element in the array.
         The array will be length 1 or more.
         FirstLast6([1, 2, 6]) → true
         FirstLast6([6, 1, 2, 3]) → true
         FirstLast6([13, 6, 1, 2, 3]) → false
         */
        public bool FirstLast6(int[] nums)
        {
            int arrayLast = nums.Length - 1;
            if (nums[0] == 6 || nums[arrayLast] == 6)
            {
                return true;
            }
            return false;
        }
    }
}
