namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            bool Inclusive30To40 (int number){
                if(number >= 30 && number <= 40)
                {
                    return true;
                }
                return false;
            }

            bool Inclusive40To50(int number)
            {
                if (number >= 40 && number <= 50)
                {
                    return true;
                }
                return false;
            }

            if ((Inclusive30To40(a) && Inclusive30To40(b)) || (Inclusive40To50(a) && Inclusive40To50(b)))
            {
                return true;
            }
            return false;
        }
    }
}
