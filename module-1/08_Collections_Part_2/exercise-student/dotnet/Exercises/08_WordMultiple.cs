using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> wordMultipleDictionary = new Dictionary<string, bool>();
            int letterCounter = 0;

            foreach (string word in words)
            {
                foreach (string wordToCompare in words)
                {
                    if (word == wordToCompare)
                    {
                        letterCounter++;
                    }
                }
                if (letterCounter >= 2)
                {
                    wordMultipleDictionary[word] = true;
                }
                else
                {
                    wordMultipleDictionary[word] = false;
                }
                letterCounter = 0;
            }

            return wordMultipleDictionary;
        }
    }
}
