using System;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Output.txt";

            string fullPath = Path.Combine(directory, filename);

            //omitting try/catch block for brevity

            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(DateTime.Now);
                sw.Write("C# ");
                sw.Write("Rocks");
                sw.WriteLine();
                sw.WriteLine("Hello World");

            }
            
            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
