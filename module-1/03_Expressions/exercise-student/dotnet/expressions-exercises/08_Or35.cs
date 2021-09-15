namespace Exercises
{
    public partial class Exercises
    {
        /*
        Return true if the given non-negative number is a multiple of 3 or a multiple of 5.
        (Hint: Think "mod".)
        Or35(3) → true
        Or35(10) → true
        Or35(8) → false
        */
        public bool Or35(int n)
        {
            bool multipleOf3 = (n % 3 == 0) == true;
            bool multipleOf5 = (n % 5 == 0) == true;

            if (multipleOf3 || multipleOf5)
            {
                return true;
            }
            return false;
        }
    }
}
