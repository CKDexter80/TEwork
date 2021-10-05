using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FindAndReplace
{
    public class SearchReplace
    {
        public static void SearchAndReplace(string search, string replace, string sourceFile, string destinationFile)
        {
            try
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                {
                    using (StreamWriter sw = new StreamWriter(destinationFile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string currentLine = sr.ReadLine();
                            string replacedLine = currentLine.Replace(search, replace);

                            sw.WriteLine(replacedLine);
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
