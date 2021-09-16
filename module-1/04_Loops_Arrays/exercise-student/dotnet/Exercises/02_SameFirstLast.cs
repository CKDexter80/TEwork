namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         SameFirstLast([1, 2, 3]) → false
         SameFirstLast([1, 2, 3, 1]) → true
         SameFirstLast([1, 2, 1]) → true
         */
        public bool SameFirstLast(int[] nums)
        {
            int arrayLast = nums.Length - 1;
            int arrayLength = nums.Length;

            if (arrayLength >= 1 && nums[0] == nums[arrayLast])
            {
                return true;
            }

            return false;
        }
    }
}
