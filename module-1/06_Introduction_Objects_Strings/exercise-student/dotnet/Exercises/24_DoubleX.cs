namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            int firstOccurenceX = str.IndexOf('x');

            if (firstOccurenceX < 0 || str.Length < 2)
            {
                return false;
            }
            else if ((str.Length - 1) == firstOccurenceX)
            {
                return false;
            }
            else if (str.Substring(firstOccurenceX, 2).Equals("xx"))
            {
                return true;
            }

            return false;
        }
    }
}
