namespace Exercises
{
    public partial class Exercises
    {
        /*
       Given 2 int values, return true if one is negative and one is positive. Except if the parameter
       "negative" is true, then return true only if both are negative.
       PosNeg(1, -1, false) → true
       PosNeg(-1, 1, false) → true
       PosNeg(-4, -5, true) → true
       */
        public bool PosNeg(int a, int b, bool negative)
        {
            bool aNegative = (a < 0) == true;
            bool bNegative = (b < 0) == true;
            bool negativeTrueCondition = (aNegative && bNegative) == true;
            bool negativeFalseCondition = (aNegative ^ bNegative) == true;

            if ((negative && negativeTrueCondition) || (!negative && negativeFalseCondition))
                    {
                return true;
            }
            
            return false;
        }
    }
}
