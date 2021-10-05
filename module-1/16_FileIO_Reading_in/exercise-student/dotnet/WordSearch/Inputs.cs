using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearch
{
    public class Inputs
    {
        public static string FullPath()
        {
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fullPath = Console.ReadLine();
            return fullPath;
        }

        public static string SearchForThis ()
        {
            Console.WriteLine("What is the search word you are looking for?");
            string search = Console.ReadLine();
            return search;
        }

        public static bool IsCaseSensitive()
        {
            Console.WriteLine(@"Should the search be case sensitive? (Y\N)");
            string caseSensitivity = Console.ReadLine().ToLower();
            if (caseSensitivity == "y")
            {
                return true;
            }
            return false;
        }
    }
}
