using System;
using System.Collections.Generic;
using System.Text;

namespace FileSplitter
{
    public class UserInputs
    {
        public static string GetFilePath()
        {
            Console.WriteLine("Where is the input file (please include the path to the file)?");
            string filePath = Console.ReadLine();
            return filePath;
        }

        public static int GetNumberOfLinesInNewFiles()
        {
            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            string lineNumberAsString = Console.ReadLine();
            int lineNumber = Int32.Parse(lineNumberAsString);
            return lineNumber;
        }
    }
}
