using System;
using System.Collections.Generic;
using System.IO;

namespace Lecture.Aids
{
    public static class LoopingCollectionToWriteFile
    {
        /*
        * This method demonstrates how we can iterate through a data structure and print its contents
        * out to a file.
        *
        * Notice how we open the StreamWriter once, write to it, then close it. It is much more effective
        * than opening and closing each individual line.
        */
        public static void LoopingADictionaryToWriteAFile()
        {
            Dictionary<string, double> programmingLanguages = new Dictionary<string, double>()
            {
                {"Java", 100.0 },
                {"C", 99.9 },
                {"C++", 99.4 },
                {"Python", 96.5 },
                {"C#", 91.3 },
                {"R", 84.8 },
                {"PHP", 84.5 },
                {"JavaScript", 83.0 },
                {"Ruby", 76.2 },
                {"Matlab", 72.4 }
            };
            string directory = Environment.CurrentDirectory;
            string filename = "programminglanguages.txt";
            string path = Path.Combine(directory, filename);

            // Open up a streamwriter for the file to write to

        }
    }
}
