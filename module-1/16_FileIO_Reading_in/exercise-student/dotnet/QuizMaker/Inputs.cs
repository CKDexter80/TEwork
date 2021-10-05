using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class Inputs
    {
        public static string getFilePath()
        {
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            string filePath = Console.ReadLine();
            return filePath;
        }
    }
}
