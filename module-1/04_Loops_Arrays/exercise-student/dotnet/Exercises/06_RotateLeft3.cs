namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2, 3}
         yields {2, 3, 1}.
         RotateLeft3([1, 2, 3]) → [2, 3, 1]
         RotateLeft3([5, 11, 9]) → [11, 9, 5]
         RotateLeft3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] RotateLeft3(int[] nums)
        {
            int zeroHolder = nums[0];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = zeroHolder;

            return nums;
        }
    }
}
