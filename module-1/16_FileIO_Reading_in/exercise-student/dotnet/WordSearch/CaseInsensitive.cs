using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordSearch
{
    public class CaseInsensitive
    {

        public static void caseInsensitiveSearch(string fullPath, string search)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    int lineNumber = 0;
                    while (!sr.EndOfStream)
                    {
                        lineNumber++;
                        string currentLine = sr.ReadLine();

                        if (currentLine.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine($"{lineNumber}) {currentLine}");
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
