namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 arrays of ints, a and b, return true if they have the same first element or they have
         the same last element. Both arrays will be length 1 or more.
         CommonEnd([1, 2, 3], [7, 3]) → true
         CommonEnd([1, 2, 3], [7, 3, 2]) → false
         CommonEnd([1, 2, 3], [1, 3]) → true
         */
        public bool CommonEnd(int[] a, int[] b)
        {
            int arrayLastA = a.Length - 1;
            int arrayLastB = b.Length - 1;

            if (a[0] == b[0] || a[arrayLastA] == b[arrayLastB])
            {
                return true;
            }

            return false;
        }
    }
}
