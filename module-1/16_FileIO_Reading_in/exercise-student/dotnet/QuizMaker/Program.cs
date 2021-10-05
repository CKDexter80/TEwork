using System;
using System.Collections.Generic;
using System.IO;

namespace QuizMaker
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = Inputs.getFilePath();
            List<Array> quizHolder =  QuizExtractor.quizExtractor(filePath);

            
                       
            
        }
    }
}
