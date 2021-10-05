using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizMaker
{
    public class Quiz
    {
        public Quiz(string question, Dictionary<int, string> answers, string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public string Question { get; private set; }
        public Dictionary<int, string> Answers { get; private set; }
        public string CorrectAnswer { get; }


    }
}
