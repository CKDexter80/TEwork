using System;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = UserInputs.GetFilePath();
            int lineNumber = UserInputs.GetNumberOfLinesInNewFiles();

            Outputs.FileLineCount(filePath);
            Outputs.TotalSplitFileCount(filePath, lineNumber);

        }
    }
}
