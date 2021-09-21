namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string removedXString = str.Replace("x", "");

            if (str.StartsWith('x') && str.Length == 1)
            {
                return "x";
            }
            else if (str.StartsWith('x') && str.EndsWith('x'))
            {
                return $"x{removedXString}x";
            }
            else if (str.StartsWith('x') && !str.EndsWith('x'))
            {
                return $"x{removedXString}";
            }
            else if (!str.StartsWith('x') && str.EndsWith('x'))
            {
                return $"{removedXString}x";
            }
           

            return removedXString;
        }
    }
}
