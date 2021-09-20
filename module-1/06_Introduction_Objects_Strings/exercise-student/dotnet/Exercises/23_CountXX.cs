namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Count the number of "xx" in the given string. Overlapping is allowed, so "xxx" contains 2 "xx".
        CountXX("abcxx") → 1
        CountXX("xxx") → 2
        CountXX("xxxx") → 3
        */
        public int CountXX(string str)
        {
            int xxCounter = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("xx"))
                {
                    xxCounter++;                        
                }
            }
            return xxCounter;
        }
    }
}
