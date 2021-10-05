using System;
using System.Collections.Generic;
using System.Text;

namespace FindAndReplace
{
    public class Inputs
    {
        public static string GetSearchWord()
        {
            Console.WriteLine("What is the search word?");
            string searchWord = Console.ReadLine();
            return searchWord;
        }
        public static string GetReplacementWord()
        {
            Console.WriteLine("What is the replacement word?");
            string replacementWord = Console.ReadLine();
            return replacementWord;
        }
        public static string GetSourceFilePath()
        {
            Console.WriteLine("What is the source file?");
            string sourceFilePath = Console.ReadLine();
            return sourceFilePath;
        }
        public static string GetDestinationFilePath()
        {
            Console.WriteLine("What is the destination file?");
            string destinationFilePath = Console.ReadLine();
            return destinationFilePath;
        }

    }
}
