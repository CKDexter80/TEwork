using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1];

            Console.WriteLine("First and Last Character. " + firstCharacter + " and " + lastCharacter);
            //string interpolation
            Console.WriteLine($"First and Last \"Character\" {firstCharacter} and { lastCharacter} ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3);
            //name.Substring(0, 3);//ignores return of Substring
            Console.WriteLine($"First 3 characters: {firstThreeCharacters}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            string lastThreeCharacters = name.Substring(name.Length - 3, 3);
            Console.WriteLine($"First and Last 3 characters: {firstThreeCharacters}{lastThreeCharacters}");

            // 4. What about the last word?
            // Output: Lovelace
            // string lastWord = name.Substring(4);
            string[] wordArray = name.Split(' ');
            string lastWord = wordArray[wordArray.Length - 1];
            Console.WriteLine($"Last Word: {lastWord}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool hasLove = name.Contains("Love");

            Console.WriteLine($"Contains \"Love\" {hasLove}");

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            int whereIsLace = name.IndexOf("lace");
            Console.WriteLine($"Index of \"lace\": {whereIsLace}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            int numberOfAs = 0;

            for (int i = 0; i < name.Length; i++)
            {
                //Console.WriteLine(name[i]);
                if (name[i] == 'a' || name[i] == 'A')
                {
                    numberOfAs++;
                }
            }

            Console.WriteLine($"Number of \"a's\": {numberOfAs}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            string adaReplacement = name.Replace("Ada", "Ada, Countess of ");

            Console.WriteLine($"Hi! My name: {adaReplacement}");

            // 9. Set name equal to null.
            int number;
            name = null;
            //string nullName = null;

            // 10. If name is equal to null or "", print out "All Done".
            //if (String.IsNullOrEmpty(name))
            if (name == null || name == "")
            {
                Console.WriteLine("All Done");
            }

            Console.ReadLine();
        }
    }
}