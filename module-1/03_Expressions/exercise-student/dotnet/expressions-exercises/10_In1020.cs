namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if either of them is in the range 10..20 inclusive.
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        public bool In1020(int a, int b)
        { 
             bool inRange(int num)
            {
                if (num >= 10 && num <= 20)
                {
                    return true;
                }
                return false;
            }
            
            if (inRange(a) || inRange(b))
            {
                return true;
            }
            return false;
        }



    }
}
