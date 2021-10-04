using System;
using System.IO;

namespace Lecture.Aids
{
    /*
    * Reading files for input involves working with streams and readers.
    */
    public static class ReadingInFiles
    {
        // Reading in a character file involves working with classes that derive from
        // TextWriter. TextWriter is an abstract class for working with character input.
        // The StreamReader inherits from TextWriter and that is often used.
        public static void ReadACharacterFile()
        {
            // Start with the file path to input
            string directory = Environment.CurrentDirectory;
            string filename = "Input.txt";

            // Create the full path
            string fullPath = Path.Combine(directory, filename);

        }
    }
}
