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

            // 1 10 3 6 8
            //set a placeholder int to 0
            //loop thru each element
            //check if larger than placeholder (if )

            int currentLargestNumber = randomNumbers[0];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > currentLargestNumber)
                {
                    currentLargestNumber = randomNumbers[i];
                }
            }

            return currentLargestNumber;
        }
    }
}
