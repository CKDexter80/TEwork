namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        2. Return the first element of the array
            TOPIC: Accessing Array Elements
        */
        public int ReturnFirstElement()
        {
                                //0    1     2   
            int[] portNumbers = { 80, 8080, 443 };
            //int[] portNumbers = new int[3] { 80, 8080, 443 }; //another, more verbose way
            //int portNumbersLengths = portNumbers.Length;
            return portNumbers[0];
        }
    }
}
