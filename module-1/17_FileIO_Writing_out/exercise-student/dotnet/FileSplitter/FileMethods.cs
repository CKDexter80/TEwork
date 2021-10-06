using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileSplitter
{
    public class FileMethods
    {
        public static int GetFileOutputSize(string filePath, int fileSizes )
        {
            int length = File.ReadAllLines(filePath).Length;
            int outputSize = (int)Math.Ceiling((double)(length) / (double)(fileSizes));
            return outputSize;
        }
    }
}
