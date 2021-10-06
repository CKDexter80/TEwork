using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileSplitter
{
    public class Splitter
    {
        public void SplitText(string filePath, int fileSize)
        {            
            int outputSize = FileMethods.GetFileOutputSize(filePath, fileSize);
            
            Console.WriteLine("**GENERATING OUTPUT**");

            //This is sweaty, I know...
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    for (int i = 1; i <= outputSize; i++)
                    {
                        string outputPath = GetNewFileName.NewFileName(filePath, i);
                        Console.WriteLine($"Generating {Path.GetFileName(outputPath)}");

                        using (StreamWriter sw = new StreamWriter(outputPath))
                        {

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
