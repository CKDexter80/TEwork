using System;
using System.IO;

namespace Lecture.Aids
{
    public static class SummingUpNumbers
    {
        public static void ReadFile()
        {
            // Reading in a file of numbers
            string folder = Environment.CurrentDirectory;
            string filename = "numbers.txt";
            // get the full path
            string fullpath = Path.Combine(folder, filename);
            int sum = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fullpath))
                {
                    while (!sr.EndOfStream)
                    {
                        string currentLine = sr.ReadLine();
                        sum += int.Parse(currentLine);
    
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
