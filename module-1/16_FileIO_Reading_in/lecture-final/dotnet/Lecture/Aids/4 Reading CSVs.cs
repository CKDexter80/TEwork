using System;
using System.Collections.Generic;
using System.IO;

namespace Lecture.Aids
{
    public static class ReadingCSVFiles
    {
        /*
        * Often programmers need to read in csv files and work with each column of data
        * individually. It usually involves reading files and doing string manipulation
        * at the same time.
        */
        public static void ReadFile()
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "words.csv";

            // Full Path
            string fullPath = Path.Combine(directory, filename);

            List<string> csvValues = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string currentLine = sr.ReadLine();
                        string[] stringArray = currentLine.Split(',');
                        foreach (string item in stringArray)
                        {
                            csvValues.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
