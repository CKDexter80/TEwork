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
            int arrayLength = nums.Length;
            int[] rotatedArray = new int[3];

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == arrayLength - 1)
                {
                   
                }

            }

            return rotatedArray;
        }
    }
}
