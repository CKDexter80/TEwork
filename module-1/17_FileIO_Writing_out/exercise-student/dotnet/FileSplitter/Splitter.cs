using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileSplitter
{
    public class Splitter
    {
        public static void SplitText(string filePath, int fileSize)
        {            
            int outputSize = FileMethods.GetFileOutputSize(filePath, fileSize);
            
            Console.WriteLine("**GENERATING OUTPUT**");
            Console.WriteLine();

            //This is sweaty, I know...
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {

                    for (int i = 1; i <= outputSize; i++)
                    {
                        List<string> splitFiles = new List<string>();

                        for (int j = 1; j <= fileSize; j++)
                        {
                            string fileLine = sr.ReadLine();
                            splitFiles.Add(fileLine);
                        }

                        string outputPath = GetNewFileName.NewFileName(filePath, i);
                        Console.WriteLine($"Generating {Path.GetFileName(outputPath)}");

                        using (StreamWriter sw = new StreamWriter(outputPath))
                        {
                            foreach (string splitFile in splitFiles)
                            {
                                sw.WriteLine(splitFile);
                            }
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
