using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class GetQuizQuestion : QuizListSorter
    {
        public GetQuizQuestion(string[] quizListItem) : base(quizListItem) { }

        public static string GetQuestion(string[] quizListItem)
        { 
            string question = quizListItem[0];
            return question;
        }
    }
}
