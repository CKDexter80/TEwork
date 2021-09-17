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
            int thirteenMarker = 0;

            void ThirteenTest(int n)
            {
                    for (int i = 0; i < arrayLength-n; i++)
                    {                       
                        if (nums[i] == 13)
                        {
                            sumLuckyNumbers += 0;
                            thirteenMarker++;
                        }
                        else if (thirteenMarker == 1)
                        {
                            sumLuckyNumbers += 0;
                            thirteenMarker = 0;
                        }

                    sumLuckyNumbers += nums[i];
                        thirteenMarker = 0;
                    }
                

            }



            if (nums[arrayLength - 1] == 13 || nums[arrayLength - 2] == 13)
            {
                ThirteenTest(2);
            }
            ThirteenTest(0);



            return sumLuckyNumbers;

        }
    }
}
