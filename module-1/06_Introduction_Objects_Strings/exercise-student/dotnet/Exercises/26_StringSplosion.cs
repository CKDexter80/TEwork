namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string explodedStringHolder = "";
            int countdownTheString = str.Length;
            
            for (int i = 0; i < str.Length; i++)
            {
                explodedStringHolder = str.Substring(0, countdownTheString) + explodedStringHolder;
                countdownTheString--;
            }
            return explodedStringHolder;
        }
    }
}
