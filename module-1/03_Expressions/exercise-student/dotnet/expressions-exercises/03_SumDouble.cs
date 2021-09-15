namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two int values, return their sum. Unless the two values are the same, then return double their sum.
         SumDouble(1, 2) → 3
         SumDouble(3, 2) → 5
         SumDouble(2, 2) → 8
         */
        public int SumDouble(int a, int b)
        {
            int sumValue = a + b;

            if (a == b)
            {
                sumValue *= 2;
            }
            return sumValue;
        }
    }
}
