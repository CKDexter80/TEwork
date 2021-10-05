using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizMaker
{
    public class QuizExtractor
    {
        public static List<Array> QuizExtraction(string filePath)
        {
            List<Array> quizHolder = new List<Array>();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string currentLine = sr.ReadLine();
                        quizHolder.Add(currentLine.Split('|'));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
            return quizHolder;
        }        
    }
}
