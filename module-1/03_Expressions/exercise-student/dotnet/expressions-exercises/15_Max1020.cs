namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            
            bool inRange(int num)
            {
                if (num >= 10 && num <= 20)
                {
                    return true;
                }
                return false;
            }

            if (inRange(a) && inRange(b))
            {
                if (a >= b)
                {
                    return a;
                }
                return b;
            }
            else if (inRange(a) && !inRange(b))
            {
                return a;
            }
            else if (!inRange(a) && inRange(b))
            {
                return b;
            }
            
            return 0;
        }
    }
}
