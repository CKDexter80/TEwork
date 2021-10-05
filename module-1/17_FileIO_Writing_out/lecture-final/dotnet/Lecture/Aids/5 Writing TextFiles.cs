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
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "output.txt";

            string fullPath = Path.Combine(directory, filename);
            //omit the try-catch for brevity
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(DateTime.Now);
                sw.Write("C# ");
                sw.Write("Rocks ");
              //  sw.WriteLine();
                sw.WriteLine("Hello World");
                
            }

            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
