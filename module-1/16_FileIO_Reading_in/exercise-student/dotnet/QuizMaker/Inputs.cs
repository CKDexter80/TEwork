using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class Inputs
    {
        public static string GetFilePath()
        {

            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            string filePath = Console.ReadLine();
            return filePath;


        }

        public static int GetAnswer()
        {
            try
            {
                Console.Write($"Your answer: ");
                string answer = Console.ReadLine();
                int answerAsInt = Int32.Parse(answer);
                return answerAsInt;
            }

            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}");
                return null;
            }

        }
    }
}
