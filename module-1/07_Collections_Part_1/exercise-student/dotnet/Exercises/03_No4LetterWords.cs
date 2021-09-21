using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Strings, return a List containing the same Strings in the same order
        except for any words that contain exactly 4 characters.
        No4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
        No4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
        No4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
        */
        public List<string> No4LetterWords(string[] stringArray)
        {
            List<string> noFourLetterWordsList = new List<string>();

            foreach (string stringWord in stringArray)
            {
                if (stringWord.Length != 4)
                {
                    noFourLetterWordsList.Add(stringWord);
                }
            }

            return noFourLetterWordsList;
        }
    }
}
