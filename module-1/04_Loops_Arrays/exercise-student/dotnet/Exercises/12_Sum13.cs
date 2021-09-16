namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do
         not count.
         Sum13([1, 2, 2, 1]) → 6
         Sum13([1, 1]) → 2
         Sum13([1, 2, 2, 1, 13]) → 6
         Sum13([1, 2, 2, 1, 13, 3]) → 6
         Sum13([1, 2, 2, 1, 13, 3, 4]) → 10
         */
        public int Sum13(int[] nums)
        {
            int sumLuckyNumbers = 0;
            int arrayLength = nums.Length;
            int counter = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                counter++;
                if (nums[i] == 13)
                {
                    break;
                }
                sumLuckyNumbers += nums[i];
            }

            for (int i = counter+1; i < arrayLength; i++)
            {
                
                if (nums[i] == 13)
                {
                    break;
                }
                sumLuckyNumbers += nums[i];
            }
            return sumLuckyNumbers;
        }
    }
}
