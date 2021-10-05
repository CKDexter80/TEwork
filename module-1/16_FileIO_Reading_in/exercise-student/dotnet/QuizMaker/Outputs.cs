using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
   public class Outputs
    {
        public static void QuestionWrite (string question)
        {
            Console.WriteLine(question);
        }
        public static void AnswersWrite(int number, string answer)
        {
            Console.WriteLine($"{number}. {answer}");
        }

        public static void FinalTally (int right, int total)
        {
            Console.WriteLine($"You got {right} answer(s) correct out of the {total} questions asked.");
        }

    }
}
