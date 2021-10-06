using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileSplitter
{
    public class GetNewFileName
    {
        public static string NewFileName(string filePath, int fileNumber)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string outputPath = Path.GetDirectoryName(filePath);
            string numberedFile = $"{fileName}-{fileNumber}.txt";
            string fullPath = Path.Combine(outputPath, numberedFile);
            return fullPath;
        }
    }
}
