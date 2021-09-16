namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int arrayLength = randomNumbers.Length;
            int sum = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (randomNumbers[i] > sum)
                {
                    sum = randomNumbers[i];
                } 
                
            }
            return sum;
        }
    }
}
