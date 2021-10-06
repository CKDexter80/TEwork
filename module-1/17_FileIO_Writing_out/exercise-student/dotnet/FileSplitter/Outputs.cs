using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileSplitter
{
    class Outputs
    {
        public static void FileLineCount(string filePath)
        {
            Console.WriteLine($"The input file has {File.ReadAllLines(filePath).Length} lines of text.");
            Console.WriteLine();
        }

        public static void TotalSplitFileCount(string filePath, int fileSizes)
        {
            int length = File.ReadAllLines(filePath).Length;
            string fileName = Path.GetFileName(filePath);
            int outputSize = FileMethods.GetFileOutputSize(filePath, fileSizes);

            Console.WriteLine("Each file that is created must have a sequential number assigned to it.");
            Console.WriteLine();
            Console.WriteLine($"For a {length} line input file \"{fileName}\", this produces {outputSize} output files.");
            Console.WriteLine();
        }
    }
}
