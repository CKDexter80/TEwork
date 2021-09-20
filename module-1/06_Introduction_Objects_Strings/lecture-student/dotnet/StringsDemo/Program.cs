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

            Console.WriteLine("First character is " + name[0] +  " and Last Character is " + name[name.Length -1] + ".");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeChar = name.Substring(0, 3); 
            Console.WriteLine($"First 3 characters: {firstThreeChar}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            string lastThreeChar = name.Substring(name.Length - 3);
            Console.WriteLine($"Last 3 characters: {firstThreeChar}{lastThreeChar}");

            // 4. What about the last word?
            // Output: Lovelace

            string[] nameSplitArray = name.Split(' ');
            string lastWord = nameSplitArray[nameSplitArray.Length - 1];

            Console.WriteLine($"Last Word: {lastWord}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            bool hasLove = name.Contains("Love");
            Console.WriteLine($"Contains \"Love\" {hasLove}");

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int whereIsLace = name.IndexOf("lace");

            Console.WriteLine($"Index of \"lace\": {whereIsLace} ");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int letterCounter = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'A')
                {
                    letterCounter++;
                }
            }

            Console.WriteLine($"Number of \"a's\": {letterCounter}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            string newName = name.Replace("Ada", "Ada, Countess of");

            Console.WriteLine(newName);

            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done".

            if (name == null || name == "")
            {
                Console.WriteLine("All Done");
            }

            Console.ReadLine();
        }
    }
}